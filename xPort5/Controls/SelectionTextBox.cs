#region Using

using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

using Gizmox.WebGUI;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms.Design;
using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Common.Extensibility;

#endregion

namespace xPort5.Controls
{
    /// <summary>
    /// Summary description for SelectionTextBox
    /// </summary>
    [ToolboxItem(true)]
    [DesignTimeController("Gizmox.WebGUI.Forms.Design.PlaceHolderController, Gizmox.WebGUI.Forms.Design, Version=3.0.5701.0, Culture=neutral, PublicKeyToken=dd2a1fd4d120c769")]
    [ClientController("Gizmox.WebGUI.Client.Controllers.PlaceHolderController, Gizmox.WebGUI.Client, Version=3.0.5701.0, Culture=neutral, PublicKeyToken=0fb8f99bd6cd7e23")]
    public partial class SelectionTextBox : TextBox
    {
        public SelectionTextBox()
        {
            InitializeComponent();

            this.CustomStyle = "SelectionTextBox";
        }

        private bool _SelectAllTextOnEnter = false;

        [DefaultValueAttribute(typeof(bool), "False")]
        [DescriptionAttribute("When user clicks or tabs into control, highlight all the text.")]
        public virtual bool SelectAllTextOnEnter
        {
            get { return _SelectAllTextOnEnter; }
            set { _SelectAllTextOnEnter = value; }
        }

        protected override void RenderAttributes(Gizmox.WebGUI.Common.Interfaces.IContext objContext, Gizmox.WebGUI.Common.Interfaces.IAttributeWriter objWriter)
        {
            if (this.SelectAllTextOnEnter)
            {
                objWriter.WriteAttributeString("SelectAllTextOnEnter", "1");
            }
            else
            {
                objWriter.WriteAttributeString("SelectAllTextOnEnter", "0");
            }

            base.RenderAttributes(objContext, objWriter);
        }

        // Called anytime the XSLT is interpreted
        public override void Update()
        {
            base.Update();
            this.CreateScriptManager();
        }

        // Called anytime the XSLT is interpreted
        public override void Update(bool blnRedrawOnly)
        {
            base.Update(blnRedrawOnly);
            this.CreateScriptManager();
        }

        private void CreateScriptManager()
        {
            // Load Control's Javascript, using gcScriptManager
            this.RegisterSelf();
            gcScriptManager myScriptManager = new gcScriptManager(this);
            this.InvokeMethod("eval", myScriptManager.GetInvokeMethodParameters());
        }
    }
}