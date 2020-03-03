using System;
using System.Data;
using System.Configuration;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common.Resources;

namespace xPort5.Controls
{

    //-------------------------------------------------------------------------------
    //[Serializable()]
    public class CheckedComboBoxForm : Form
    {
        CheckedComboBox mobjParent = null;
        CheckedComboBoxView objCheckedComboView = null;

        public CheckedComboBoxView GetCheckedComboBoxView()
        {
            return objCheckedComboView;
        }
        public CheckedComboBox GetCheckedComboBox()
        {
            return mobjParent;
        }
        public CheckedComboBoxForm(CheckedComboBox objParent)
        {
            mobjParent = objParent;

            this.Width = 250;
            this.Height = 200;

            objCheckedComboView = new CheckedComboBoxView();
            objCheckedComboView.Dock = DockStyle.Fill;

            this.Controls.Add(objCheckedComboView);

            objCheckedComboView.ItemCheck += new ItemCheckHandler(OnItemCheck);
            objCheckedComboView.DoubleClick += new EventHandler(OnClose);
            objCheckedComboView.MouseDown += new MouseEventHandler(OnMouseDown);
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                this.Close();
        }
        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnItemCheck(object sender, ItemCheckEventArgs e)
        {
            mobjParent.Text = "";
            foreach(int i in objCheckedComboView.CheckedIndices)
            {
                if(mobjParent.Text != string.Empty)
                    mobjParent.Text += "; ";  
                mobjParent.Text += objCheckedComboView.Items[i].ToString();  
            }
        }
        public void AddString(string newValue, bool bChecked)
        {
            if (newValue == null || newValue == string.Empty)
                return;
            
            objCheckedComboView.Items.Add(newValue, bChecked);
        }
        public void SelectAll(bool bChecked)
        {
            for (int i = 0; i < objCheckedComboView.Items.Count; i++)
            {
                objCheckedComboView.SetItemChecked(i, bChecked);
            }
        }
        public void Clear()
        {
            objCheckedComboView.Items.Clear();
        }
        public int Count()
        {
            return objCheckedComboView.Items.Count;
        }
        public void SetCheckWithText(string text)
        {
            string ls_aux;
            string ls_checkStr;
            int pos;

            if (text == null || text == string.Empty)
            {
                SelectAll(false);
                return;
            }

            ls_aux = text;

            SelectAll(false);

            pos = ls_aux.IndexOf("; ");
            while (ls_aux != string.Empty && pos != -1)
            {
                ls_checkStr = ls_aux.Substring(0, pos);
                ls_aux = ls_aux.Substring(pos + 2);
                SetCheck(ls_checkStr, true);
                pos = ls_aux.IndexOf("; ");
            }
            // seleccionar o que sobra
            if (ls_aux != string.Empty)
                SetCheck(ls_aux, true);
        }
        public int SetCheck(string nText, bool bChecked)
        {
            if (nText == null || nText == string.Empty)
                return -1;

            int pos = objCheckedComboView.FindString(nText);
            objCheckedComboView.SetItemChecked(pos, bChecked);
            return pos;
        }
        public bool GetCheck(int nIndex)
        {
            return objCheckedComboView.GetItemChecked(nIndex);
        }
        public void SetCheck(int nIndex, bool bChecked)
        {
            objCheckedComboView.SetItemChecked(nIndex, bChecked);
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
    //-------------------------------------------------------------------------------
    //[Serializable()]
    public class CheckedComboBox : ComboBox
    {
        private CheckedComboBoxForm mobjDropDown = null;

        public CheckedComboBox()
        {
            this.DropDownStyle = ComboBoxStyle.DropDown;

            if (mobjDropDown == null)
            {
                mobjDropDown = new CheckedComboBoxForm(this);
            }
        }
        protected override Form GetCustomDropDown()
        {

            return mobjDropDown;
        }

        public void AddString(string newValue, bool bChecked)
        {
            mobjDropDown.AddString(newValue, bChecked);
        }
        public CheckedComboBoxView GetCheckedComboView()
        {
            return mobjDropDown.GetCheckedComboBoxView();
        }
        public void SelectAll(bool bChecked)
        {
            mobjDropDown.SelectAll(bChecked);
        }
        public void Clear()
        {
            mobjDropDown.Clear();
        }
        public void SetCheckWithText(string text)
        {
            mobjDropDown.SetCheckWithText(text);
        }
        public bool GetCheck(int nIndex)
        {
            return mobjDropDown.GetCheck(nIndex);
        }
        public void SetCheck(int nIndex, bool bChecked)
        {
            mobjDropDown.SetCheck(nIndex, bChecked);
        }
        public int Count()
        {
            return mobjDropDown.Count();
        }
        public void SetWidth(int nWidth)
        {
            mobjDropDown.Width = nWidth;
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
    public class CheckedComboBoxView : CheckedListBox
    {
        public CheckedComboBoxView()
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
