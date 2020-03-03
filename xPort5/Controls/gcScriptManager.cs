using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common.Gateways;

// Authored by:	GeniusCode.net - Ryan D. Hatch & Jeremiah Redekop
// Date:		2009.09.14
// License:		BSD

namespace xPort5.Controls
{
    public class gcScriptManager : Component, IDisposable
    {

		private Control myControl;

		public gcScriptManager(Control argControl)
		{
			myControl = argControl;

			// Force registration of myself - since we don't have access to the MainForm / ActiveForm, because we could be getting called from the MainForm.Designer.cs
			this.RegisterSelf();
		}

		public object[] GetInvokeMethodParameters()
		{
			return new object[1] { GetLoadRemoteJavaScript() };
		}

		private string GetLoadRemoteJavaScript()
		{

			string myJavaScriptURL = new GatewayReference(this, "emptyAction").ToString();

			string myString = @"
					var myFunction = function(url, callBack, myCallbackParameter) {
						var head = document.getElementsByTagName(""head"")[0];
						var script = document.createElement(""script"");
						script.src = url;
						var done = false;
						script.onload = script.onreadystatechange = function() {
							if (!done && (!this.readyState
									|| this.readyState == ""loaded""
									|| this.readyState == ""complete"")) {
								done = true;
								if (typeof callBack != ""undefined"") callBack(myCallbackParameter);
								// Handle memory leak in IE
								script.onload = script.onreadystatechange = null;
								head.removeChild(script);
							}
						}
						head.appendChild(script);
						return undefined;
					}
				
					// Unset flag so other instances of this control-type can load
					var myScriptLoadedCallback = function() { " + getLoadControlMethodName() + @"Loading = false; }

					if (this." + getLoadControlMethodName() + @"Loading == ""undefined"" || this." + getLoadControlMethodName() + @"Loading == null)
					{
						// Javascript not yet loaded - Load it

						// Set Flag to prevent multiple controls of the same type trying to load Javascript at the same time
						" + getLoadControlMethodName() + @"Loading = true;

						myFunction(""" + myJavaScriptURL + @""", myScriptLoadedCallback, null);

					} else {

						// Javascript already loaded - Use existing

							var waitForJavascriptToLoad = function(callback) {

									if (this." + getLoadControlMethodName() + @"Loading == false)
									{
										// Javascript for this control is ready & already loaded - Go ahead
										this." + getLoadControlJavaScript() + @"
									} else {
										// Javascript for this control is currently being loaded by another instance
										// We need to wait until Javascript is loaded successfully

										setTimeout(callback, 100);
									}

								}

							waitForJavascriptToLoad(waitForJavascriptToLoad);

					}

					";

			return myString;

		}

		// Processes a Get Javascript Request
		protected override Gizmox.WebGUI.Common.Interfaces.IGatewayHandler ProcessGatewayRequest(System.Web.HttpContext objHttpContext, string strAction)
		{
			// Force unregister myself
			this.UnRegisterSelf();

			// Write Javascript to Browser
			objHttpContext.Response.ContentType = "text/javascript";

			// Custom Javascript, with Execute
			string myJavaScript = getCustomJavaScript() + getLoadControlJavaScript();

			objHttpContext.Response.Write(myJavaScript);
			return null;
		}

		// Name of Javascript event to fire to initialize the Control
		private string getLoadControlMethodName()
		{
			return myControl.GetType().Name + "_LoadControl";
		}

		// Executes Javascript event to fire to initialize the Control
		private string getLoadControlJavaScript()
		{
            //return getLoadControlMethodName() + "(" + myControl.Guid + ");";
            return "";
		}
		
		// Retrieves Javascript file from Assembly using Embedded Resource
		private string getCustomJavaScript()
		{

			Type myControlType = myControl.GetType();
			Assembly myAssembly = myControlType.Assembly;
			
			string myString;

			// The name of the resource Foo.txt will be prefixed with the name of the assembly.
            string JavascriptResourceName = String.Format("{0}.js", myControlType.FullName);
			using (Stream myFileStream = myAssembly.GetManifestResourceStream(JavascriptResourceName))
			  {
				  using (StreamReader myReader = new StreamReader(myFileStream))
			      {
					  myString = myReader.ReadToEnd();
			      }
			  }

			return myString;
		
		}

		void IDisposable.Dispose()
		{
			myControl = null;
		}

	}
}
