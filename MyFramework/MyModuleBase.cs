using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using DotNetNuke.Entities.Modules;

namespace MyFramework
{
    public abstract class MyModuleBase: PortalModuleBase
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MyFramework.scripts.globals.js";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string script = reader.ReadToEnd();
                script=script.Replace("@ApplicationName", ApplicationName);
                Page.ClientScript.RegisterClientScriptBlock(typeof(MyModuleBase),"globlas",script,true);
            }

            

            Page.ClientScript.RegisterClientScriptResource(typeof(MyModuleBase), "MyFramework.scripts.view.js");

            string csslink = "<link href='" +
            Page.ClientScript.GetWebResourceUrl(typeof(MyModuleBase),
           "MyFramework.content.css.view.css")
          + "' rel='stylesheet' type='text/css' />";
            LiteralControl include = new LiteralControl(csslink);
            Page.Header.Controls.Add(include);
            
        }

        protected abstract string ApplicationName { get; }
    }
}
