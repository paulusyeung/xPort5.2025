using System;
using System.Data;
using System.Configuration;
using Gizmox.WebGUI.Forms;
using System.ComponentModel;
using System.Collections;
using System.Drawing.Design;
using System.Text.RegularExpressions;

namespace xPort5.Controls
{
    public class DataListView : ListView, IComparer
    {
        #region Private Properties
        /// <summary>
        /// Hold the listview datasource
        /// </summary>
        private object mobjDataSource = null;

        /// <summary>
        /// Hold the listview data member
        /// </summary>
        private string mstrDataMember = null;

        /// <summary>
        /// Holds the current currecy manager
        /// </summary>
        private CurrencyManager mobjCurrencyManager = null;

        /// <summary>
        /// A flag indicating if to create columns automaticly
        /// </summary>
        private bool mblnAutoColumnGeneration = true;

        /// <summary>
        /// The column headers resizing mide
        /// </summary>
        private ColumnHeaderAutoResizeStyle menmColumnHeaderAutoResizeStyle = ColumnHeaderAutoResizeStyle.None;

        /// <summary>
        /// Collection of sorting columns
        /// </summary>
        private ICollection mobjSortingColumns = null;

        /// <summary>
        /// Holds columns to properties mappings
        /// </summary>
        private Hashtable mobjColumnProperties = null;

        /// <summary>
        /// Holds the original item sorting
        /// </summary>
        private ArrayList mobjOriginalItemSorting = null;

        #endregion

        /// <summary>
        /// Creates a new DataListView
        /// </summary>
        public DataListView()
        {
            // Allow internal paging
            this.UseInternalPaging = true;

            // Bind selected index to currency manager
            this.SelectedIndexChanged += new EventHandler(DataListView_SelectedIndexChanged);

            // Set sorting comparer
            this.ListViewItemSorter = this;

            // Prepare sorting array
            this.mobjOriginalItemSorting = new ArrayList();
        }

        /// <summary>
        /// Gets or sets if auto column generation is active
        /// </summary>
        [DefaultValue(true)]
        public bool AutoColumnGeneration
        {
            get
            {
                return mblnAutoColumnGeneration;
            }
            set
            {
                if (mblnAutoColumnGeneration != value)
                {
                    mblnAutoColumnGeneration = value;
                    this.Bind();
                }

            }
        }

        /// <summary>
        /// Gets or sets if column auto resizing mode
        /// </summary>
        [DefaultValue(ColumnHeaderAutoResizeStyle.None)]
        public ColumnHeaderAutoResizeStyle ColumnResizeStyle
        {
            get
            {
                return menmColumnHeaderAutoResizeStyle;
            }
            set
            {
                // If value is diffrent
                if (menmColumnHeaderAutoResizeStyle != value)
                {
                    // Set value
                    menmColumnHeaderAutoResizeStyle = value;

                    // Auto resize columns
                    AutoResizeColumns();
                }
            }
        }

        /// <summary>
        /// The listview data source
        /// </summary>
        [RefreshProperties(RefreshProperties.Repaint), AttributeProvider(typeof(Binding.IDataSourceAttributeProvider))]
        public object DataSource
        {
            get
            {
                return mobjDataSource;
            }
            set
            {
                if (mobjDataSource != value)
                {
                    mobjDataSource = value;
                    Bind();
                }
            }
        }

        /// <summary>
        /// The listview data memeber
        /// </summary>
        [Editor("Gizmox.WebGUI.Forms.Design.DataMemberListEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor)), DefaultValue("")]
        public string DataMember
        {
            get
            {
                return mstrDataMember;
            }
            set
            {
                if (mstrDataMember != value)
                {
                    mstrDataMember = value;
                    Bind();
                }
            }
        }

        /// <summary>Raises the <see cref="E:Gizmox.WebGUI.Forms.Control.BindingContextChanged"></see> event.</summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> that contains the event data. </param>
        protected override void OnBindingContextChanged(EventArgs e)
        {
            this.Bind();
        }

        /// <summary>
        /// Bind listview to data
        /// </summary>        
        private void Bind()
        {
            
            if (this.BindingContext != null)
            {
                // Clear current list context
                if (mblnAutoColumnGeneration)
                {
                    // If in design mode unregister columns
                    if (this.DesignMode)
                    {
                        // Loop all columns and unregister them
                        foreach (ColumnHeader objColumnHeader in this.Columns)
                        {
                            UnregisterInDesignMode(objColumnHeader);
                        }
                    }

                    // Clear columns
                    this.Columns.Clear();
                }

                // Clear items
                this.Items.Clear();

                // Clear original sorting array
                this.mobjOriginalItemSorting.Clear();

                IList objList = null;

                // If valid mappings
                if (mobjDataSource != null)
                {
                    // Try to get list
                    if (mstrDataMember == null)
                    {
                        // Get list from datasource
                        objList = ListBindingHelper.GetList(mobjDataSource) as IList;
                    }
                    else
                    {
                        // Get list from datasource and datamember
                        objList = ListBindingHelper.GetList(mobjDataSource, mstrDataMember) as IList;
                    }

                    // Get currency manager
                    this.UnWireEvents();
                    this.mobjCurrencyManager = this.BindingContext[mobjDataSource, mstrDataMember] as CurrencyManager;
                    this.WireEvents();

                    // If is a valid list
                    if (objList != null && !(objList is DataViewManager))
                    {
                        // Get properties from list
                        PropertyDescriptorCollection objProperties = ListBindingHelper.GetListItemProperties(objList);
                        if (objProperties != null)
                        {
                            // Column related properties
                            mobjColumnProperties = new Hashtable();
                            
                            // Loop all properties
                            foreach (PropertyDescriptor objProperty in objProperties)
                            {
                                // Add column property mapping
                                mobjColumnProperties[objProperty.Name] = objProperty;

                                // If auto generation of columns is required
                                if (mblnAutoColumnGeneration)
                                {
                                    // Get column 
                                    ColumnHeader objColumn = GetColumnFromProperty(objProperty);
                                    if (objColumn != null)
                                    {
                                        // Set column mapping
                                        objColumn.Tag = objProperty.Name;

                                        // Register column if needed
                                        this.RegisterInDesignMode(objColumn, objProperty.Name);

                                        // Add column
                                        this.Columns.Add(objColumn);
                                    }

                                }
                            }

                            // Loop all rows in list
                            foreach (object objRow in objList)
                            {
                                ListViewItem objListViewItem = null;

                                // Loop all coluns
                                foreach (ColumnHeader objColumnHeader in this.Columns)
                                {
                                    // Get new property
                                    PropertyDescriptor objProperty = mobjColumnProperties[objColumnHeader.Tag] as PropertyDescriptor;

                                    // The current value
                                    string strValue = "";

                                    // If property found
                                    if (objProperty != null)
                                    {
                                        strValue = GetRowItemValueFromRow(objRow, objProperty);
                                    }

                                    // If not created listviewitem for row
                                    if (objListViewItem == null)
                                    {
                                        // Create listvieitem
                                        objListViewItem = this.Items.Add(strValue);

                                        // Store row for sorting
                                        objListViewItem.Tag = objRow;

                                        // Add current item
                                        mobjOriginalItemSorting.Add(objListViewItem);
                                    }
                                    else
                                    {
                                        // Add sub item
                                        objListViewItem.SubItems.Add(strValue);
                                    }
                                }
                            }

                            // Resize columns
                            AutoResizeColumns();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Do column resizing
        /// </summary>
        private void AutoResizeColumns()
        {
            // If auto column sizing is required
            if (this.ColumnResizeStyle != ColumnHeaderAutoResizeStyle.None)
            {
                // Loop all columns
                for (int intIndex = 0; intIndex < this.Columns.Count; intIndex++)
                {
                    // Resize column
                    this.AutoResizeColumn(intIndex, this.ColumnResizeStyle);
                }
            }
        }

        /// <summary>
        /// Unwire currency manager event
        /// </summary>
        private void UnWireEvents()
        {
            if (this.mobjCurrencyManager != null)
            {
                this.mobjCurrencyManager.PositionChanged -= new EventHandler(this.CurrencyManager_PositionChanged);
                this.mobjCurrencyManager.ListChanged -= new ListChangedEventHandler(this.CurrencyManager_ListChanged);
            }
        }

        /// <summary>
        /// Wire currency manager events
        /// </summary>
        private void WireEvents()
        {
            if (this.mobjCurrencyManager != null)
            {
                this.mobjCurrencyManager.PositionChanged += new EventHandler(this.CurrencyManager_PositionChanged);
                this.mobjCurrencyManager.ListChanged += new ListChangedEventHandler(this.CurrencyManager_ListChanged);
            }
        }

        /// <summary>
        /// Handle list view selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mobjCurrencyManager != null)
            {
                int intPosition = mobjOriginalItemSorting.IndexOf(this.SelectedItem);
                this.mobjCurrencyManager.Position = intPosition;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyManager_PositionChanged(object sender, EventArgs e)
        {
            // If valid position
            if (this.mobjCurrencyManager.Position < mobjOriginalItemSorting.Count)
            {
                // If valid position
                if (this.mobjCurrencyManager.Position > -1 && this.mobjCurrencyManager.Position < this.mobjOriginalItemSorting.Count)
                {
                    // Get position listviewitem
                    ListViewItem objItem = mobjOriginalItemSorting[this.mobjCurrencyManager.Position] as ListViewItem;

                    // If selected index needs to be updated
                    if (this.SelectedItem != objItem)
                    {
                        // Update selected item and list
                        this.SelectedItem = objItem;
                        this.Update();
                    }
                }
                else
                {
                    // Clear selection
                    this.SelectedIndex = -1;
                    this.Update();
                }
            }
        }

        /// <summary>
        /// Handle list change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyManager_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.Bind();
        }

        /// <summary>
        /// Get column from property
        /// </summary>
        /// <param name="objProperty"></param>
        /// <returns></returns>
        protected virtual ColumnHeader GetColumnFromProperty(PropertyDescriptor objProperty)
        {
            bool blnCreateColumn = false;

            TypeConverter objConverter = objProperty.Converter;
            if(objConverter!=null)
            {
                if (objConverter.CanConvertTo(typeof(string)))
                {
                    blnCreateColumn = true;
                }
            }

            // If should create column
            if (blnCreateColumn)
            {
                return CreateColumnFromProperty(objProperty);
            }

            return null;
            
        }

        /// <summary>
        /// Creates the column
        /// </summary>
        /// <param name="objProperty"></param>
        /// <returns></returns>
        protected virtual ColumnHeader CreateColumnFromProperty(PropertyDescriptor objProperty)
        {
            ColumnHeader objColumn = new ColumnHeader();
            objColumn.Label = objProperty.DisplayName;
            objColumn.Width = 100;            
            return objColumn;
        }

        /// <summary>
        /// Register column header in design mode
        /// </summary>
        /// <param name="objColumn"></param>
        /// <param name="strName"></param>
        private void RegisterInDesignMode(ColumnHeader objColumn,string strName)
        {
            if (this.DesignMode)
            {
                if (this.Site!=null && this.Site.Container!=null)
                {
                    if (objColumn.Site == null)
                    {
                        this.Site.Container.Add(objColumn, GetSafeName(strName,this.Site.Container));
                    }
                }
            }
        }

        /// <summary>
        /// Get safe name for column header
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="objContainer"></param>
        /// <returns></returns>
        private string GetSafeName(string strName, IContainer objContainer)
        {
            Regex objRegex = new Regex("[^a-zA-Z0-9]", RegexOptions.CultureInvariant);
            string strSafeName = "column"+objRegex.Replace(strName, "_");
            if (objContainer.Components[strSafeName] == null)
            {
                return strSafeName;
            }
            int intIndex = 1;
            while (objContainer.Components[strSafeName + intIndex.ToString()] != null)
            {
                intIndex++;
            }
            return strSafeName + intIndex.ToString();
        }

        /// <summary>
        /// Unregister column header in design mode
        /// </summary>
        /// <param name="objColumn"></param>
        /// <param name="strName"></param>
        private void UnregisterInDesignMode(ColumnHeader objColumn)
        {
            if (this.DesignMode)
            {
                if (this.Site != null && this.Site.Container != null)
                {
                    if (objColumn.Site != null)
                    {
                        this.Site.Container.Remove(objColumn);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the row item value
        /// </summary>
        /// <param name="objRow"></param>
        /// <param name="objProperty"></param>
        /// <returns></returns>
        protected virtual object GetRowItemValueFromRowAsObject(object objRow, PropertyDescriptor objProperty)
        {
            if (objProperty != null && objRow != null)
            {
                return objProperty.GetValue(objRow);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the row item value
        /// </summary>
        /// <param name="objRow"></param>
        /// <param name="objProperty"></param>
        /// <returns></returns>
        protected virtual string GetRowItemValueFromRow(object objRow, PropertyDescriptor objProperty)
        {
            object objValue = objProperty.GetValue(objRow);
            string strValue = "";
            if (objValue != null)
            {
                TypeConverter objConverter = objProperty.Converter;
                if (objConverter != null)
                {
                    strValue = (string)objProperty.Converter.ConvertTo(objValue, typeof(string));
                }
                else
                {
                    strValue = objValue.ToString();
                }
            }

            return strValue;
        }

        #region IComparer Members

        /// <summary>
        /// Override sorting
        /// </summary>
        public override void Sort()
        {
            ColumnHeaderSortingData objSortData = new ColumnHeaderSortingData(this);
            mobjSortingColumns = objSortData.SortingColumns;
            objSortData = null;
            base.Sort();
        }

        /// <summary>
        /// Compares two ListView Items
        /// </summary>
        /// <param name="objObjectA">object A.</param>
        /// <param name="objObjectB">object B.</param>
        /// <returns></returns>
        int IComparer.Compare(object objObjectA, object objObjectB)
        {
            // Get list viewitems
            ListViewItem objItemA = objObjectA as ListViewItem;
            ListViewItem objItemB = objObjectB as ListViewItem;



            ICollection objSortingColumns = this.mobjSortingColumns;

            // Check valid items
            if (objItemA != null && objItemB != null && mobjColumnProperties!=null)
            {
                object objRowA = objItemA.Tag;
                object objRowB = objItemB.Tag;

                if (objItemA != null && objItemB != null)
                {
                    // Check that there are columns
                    if (objSortingColumns.Count == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        // Loop all sorting columns
                        foreach (ColumnHeader objColumn in objSortingColumns)
                        {
                            IComparable objComparerA = GetRowItemValueFromRowAsObject(objRowA, mobjColumnProperties[objColumn.Tag] as PropertyDescriptor) as IComparable;
                            object objValueB = GetRowItemValueFromRowAsObject(objRowB, mobjColumnProperties[objColumn.Tag] as PropertyDescriptor);

                            if (objComparerA != null && objValueB != null)
                            {
                                // Get sorting direction
                                int intDirection = (objColumn.SortOrder == SortOrder.Ascending) ? 1 : -1;

                                // The comparison result
                                int intResult = 0;
                                intResult = objComparerA.CompareTo(objValueB);
                                if (intResult != 0) return intResult * intDirection;
                            }
                            else if (objComparerA == null && objValueB!=null)
                            {
                                return -1;
                            }
                            else if (objComparerA != null && objValueB == null)
                            {
                                return 1;
                            }
                        }

                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }


        #endregion IComparer Members
    }


}
