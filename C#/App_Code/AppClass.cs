using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EventRegister
{
    public class AppClass
    {
        public enum BootstrapAlertType { Plain, Success, Information, Warning, Danger, Primary };
        public static void BootstrapAlert(Label MsgLabel, String Message, BootstrapAlertType MessageType = BootstrapAlertType.Plain, bool Dismissable = true)
        {
            string style = "";
            string icon = "";

            switch (MessageType)
            {
                case BootstrapAlertType.Plain:
                    style = "default";
                    icon = "";
                    break;
                case BootstrapAlertType.Success:
                    style = "success";
                    icon = "check";
                    break;
                case BootstrapAlertType.Information:
                    style = "info";
                    icon = "info-circle";
                    break;
                case BootstrapAlertType.Warning:
                    style = "warning";
                    icon = "warning";
                    break;
                case BootstrapAlertType.Danger:
                    style = "danger";
                    icon = "remove";
                    break;
                case BootstrapAlertType.Primary:
                    style = "primary";
                    icon = "info";
                    break;
            }
            if((!MsgLabel.Page.IsPostBack || MsgLabel.Page.IsPostBack) && Message == ""){
                MsgLabel.Visible = false;
            }
            else
            {
                MsgLabel.Visible = true;
                MsgLabel.CssClass = "alert alert-"  + style + " alert-dismissible fade show";
                MsgLabel.Text = "<i class='fa fa-" + icon + "'></i>" + Message;
                if(Dismissable == true)
                {
                    MsgLabel.Text += "<button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span>";
                }
            }
            
        }
    }
}