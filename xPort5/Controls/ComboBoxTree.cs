using System;
using System.Data;
using System.Configuration;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common.Resources;

namespace xPort5.Controls
{


    //[Serializable()]
	public class ComboBoxTreeForm : Form
    {
        ComboBoxTree mobjParent = null;
        ComboBoxTreeTreeView objTreeView = null;

        public ComboBoxTreeTreeView GetComboBoxTreeTreeView()
        {
            return objTreeView;      
        }
        public ComboBoxTree GetComboBoxTree()
        {
            return mobjParent;      
        }
        public ComboBoxTreeForm(ComboBoxTree objParent)
        {
            mobjParent = objParent;

            this.Width = 250;
            this.Height = 400;

            objTreeView = new ComboBoxTreeTreeView();
            objTreeView.Dock = DockStyle.Fill;
            
            this.Controls.Add(objTreeView);

            objTreeView.AfterSelect += new TreeViewEventHandler(OnAfterSelect);
            objTreeView.BeforeExpand += new TreeViewCancelEventHandler(OnBeforeExpand);

            objTreeView.DoubleClick += new EventHandler(OnClose);
            objTreeView.MouseDown += new MouseEventHandler(OnMouseDown);
            //objTreeView.Leave += new EventHandler(OnClose);
            //objTreeView.LostFocus += new EventHandler(OnClose);
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.Close();
        }
        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnAfterSelect(object sender, TreeViewEventArgs e)
        {
            mobjParent.Text = e.Node.Text;
            this.Close();
        }
        private void OnBeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
        }


        public void AddNode(TreeNodeCollection objNodesParent, TreeNode objTreeNodeNew)
        {
            objNodesParent.Add(objTreeNodeNew);
        }
        public void Clear()
        {
            objTreeView.Nodes.Clear();
        }
        public void CollapseAll()
        {
            objTreeView.CollapseAll();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        private void ItemCheck(object objSender, ItemCheckEventArgs objArgs)
        {

        }
    }

    //[Serializable()]
	public class ComboBoxTree : ComboBox
    {
        private ComboBoxTreeForm mobjDropDown = null;

        public ComboBoxTree()
        {
            this.DropDownStyle = ComboBoxStyle.DropDown;
            
            if (mobjDropDown == null)
            {
                mobjDropDown = new ComboBoxTreeForm(this);                
            }
        }
        protected override Form GetCustomDropDown()
        {
            return mobjDropDown;
        }

        public void AddNode(TreeNodeCollection objNodesParent, TreeNode objTreeNodeNew)
        {
            mobjDropDown.AddNode(objNodesParent, objTreeNodeNew);
        }
        public void Clear()
        {
            mobjDropDown.Clear();
        }
        public ComboBoxTreeTreeView GetTreeView()
        {
            return mobjDropDown.GetComboBoxTreeTreeView();
        }
        public void SetWidth(int nWidth)
        {
            mobjDropDown.Width = nWidth;
        }
        public void CollapseAll()
        {
            mobjDropDown.CollapseAll();
        }

        protected override bool IsCustomDropDown
        {
            get
            {
                return true;
            }
        }
    }

    //[Serializable()]
	public class ComboBoxTreeTreeView : TreeView
    {
        public ComboBoxTreeTreeView()
        {

        }

        protected override bool IsDelayedDrawing
        {
            get
            {
                return false;
            }
        }
    }
}
