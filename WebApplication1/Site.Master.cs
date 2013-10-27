using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Web.Security;

namespace WebApplication1
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                userOrNot.Text = Session["user"] == null ? "Giriş" : Session["user"].ToString() + " (Çıkış)";
            }
        }

        protected void userOrNot_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("~/Account/Login.aspx");
            else
            {
                Session["user"] = null;
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}
