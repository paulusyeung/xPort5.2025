using System;
using System.Data;
using System.Configuration;
using Gizmox.WebGUI.Forms;

namespace xPort5.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class ListComboBox : ComboBox
    {
        private String _DropDownHeight = "100";

        /// <summary>
        /// 
        /// </summary>
        public class ListComboBoxForm : Form
        {
            /// <summary>
            /// 
            /// </summary>
            private ListView mobjList = null;

            /// <summary>
            /// Initializes a new instance of the <see cref="ListComboBoxForm"/> class.
            /// </summary>
            public ListComboBoxForm()
            {
                mobjList = new ListView();
                mobjList.MultiSelect = false;
                mobjList.Dock = DockStyle.Fill;
                mobjList.SelectedIndexChanged += new EventHandler(OnSelectedIndexChanged);
                this.Controls.Add(mobjList);
            }

            #region Start modify
            private void list_KeyDown(object objSender, KeyEventArgs objArgs)
            {
                if (objArgs.KeyCode == Keys.Enter)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            public ListView getListView()
            {
                return mobjList;
            }
            #endregion End modify

            /// <summary>
            /// Called when selected index changed.
            /// </summary>
            /// <param name="sender">The sender.</param>
            /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
            private void OnSelectedIndexChanged(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            /*
            * ListView and LsitBox are heavy data controls and as for 
            * that VWG renders them with delay. It does it through the 
            * IsDelayedDrawing property. 
            * In order to make the ListBox and the ListView controls work 
            * properly over IE popup window, they must be inherited and 
            * override the IsDelayedDrawing property (returning false)
            * so that it won’t be draw with delay
            */
            protected override bool IsDelayedDrawing
            {
                get
                {
                    return false;
                }
            }

            /// <summary>
            /// Gets the list.
            /// </summary>
            /// <value>The list.</value>
            public ListView List
            {
                get { return mobjList; }
            }

            /// <summary>
            /// Gets the width of the required.
            /// </summary>
            /// <value>The width of the required.</value>
            public int RequiredWidth
            {
                get
                {
                    int intWidth = 20;
                    foreach (ColumnHeader objColumn in mobjList.Columns)
                    {
                        intWidth += objColumn.Width + 2;
                    }
                    return intWidth;
                }
            }
        }

        #region Start modify
        private void InvokeFocusCommand(Control c)
        {
            Gizmox.WebGUI.Common.Interfaces.IApplicationContext objApplicationContext = (Gizmox.WebGUI.Common.Interfaces.IApplicationContext)this.Context;

            //if (objApplicationContext != null)
            //    objApplicationContext.SetFocused(c);
        }

        private void FireDummyFocusingEvent()
        {
            this.InvokeMethodWithId("Events_CreateEvent", "DropDownWindowContinued");
            this.InvokeMethod("Events_RaiseEvents");
        }

        protected override void FireEvent(Gizmox.WebGUI.Common.Interfaces.IEvent objEvent)
        {
            if (objEvent.Type == "DropDownWindow")
            {
                base.FireEvent(objEvent);
                FireDummyFocusingEvent();
            }
            else if (objEvent.Type == "DropDownWindowContinued")
            {
                this.InvokeFocusCommand(mobjForm.getListView());
            }
            else
            {
                base.FireEvent(objEvent);
            }
        }
        #endregion End modify

        /// <summary>
        /// 
        /// </summary>
        private ListComboBoxForm mobjForm = null;

        /// <summary>
        /// Occurs when selected item changed.
        /// </summary>
        public event EventHandler SelectedItemChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComboBox"/> class.
        /// </summary>
        public ListComboBox()
        {
            mobjForm = new ListComboBoxForm();
            mobjForm.Closed += new EventHandler(OnFormClosed);
            this.DropDownStyle = ComboBoxStyle.DropDown;
        }

        /// <summary>
        /// Called when form is closed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnFormClosed(object sender, EventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                if (this.SelectedItem != null)
                {
                    this.Text = this.SelectedItem.Text;
                }

                if (SelectedItemChanged != null)
                {
                    SelectedItemChanged(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance has a custom drop down.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance has a custom drop down; otherwise, <c>false</c>.
        /// </value>
        protected override bool IsCustomDropDown
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets the custom form to display as drop down
        /// </summary>
        /// <returns></returns>
        protected override Form GetCustomDropDown()
        {
            mobjForm.DialogResult = DialogResult.None;
            mobjForm.Width = Math.Max(this.Width, mobjForm.RequiredWidth);
            mobjForm.Height = Convert.ToInt32(_DropDownHeight);
            return mobjForm;
        }

        /// <summary>
        ///  Gets the collection of columns contained within the listview.
        /// </summary>
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ListView.ColumnHeaderCollection Columns
        {
            get
            {
                return mobjForm.List.Columns;
            }
        }

        /// <summary>
        ///  Gets the collection of items contained within the listview.
        /// </summary>
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new ListView.ListViewItemCollection Items
        {
            get
            {
                return mobjForm.List.Items;
            }
        }

        /// <summary>
        /// Gets the currently selected item index.
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new ListViewItem SelectedItem
        {
            get
            {
                return mobjForm.List.SelectedItem;
            }
            set
            {
                mobjForm.List.SelectedItem = value;
            }
        }

        /// <summary>
        /// Set the hright of the dropdown panel.
        /// </summary>
        [System.ComponentModel.Description("Height of the dropdown panel.\nVertical scrollbar works in IE only. For Webkit browsers, use a height to show all items.")]
        [System.ComponentModel.Category("Behavior")]
        [System.ComponentModel.DefaultValue("100")]
        public String DropDownHeight
        {
            get
            {
                return _DropDownHeight;
            }
            set
            {
                _DropDownHeight = value;
            }
        }
    }
}
