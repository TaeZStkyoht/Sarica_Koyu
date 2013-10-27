using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
                Response.Redirect("~/Default.aspx");
            username.Focus();
        }

        protected void enter_Click(object sender, EventArgs e)
        {
            if (new Manager().UserControl(username.Text, password.Text))
            {
                Session.Add("user", username.Text);
                Response.Redirect("~/Default.aspx");
            }
            else
                errMsg.Visible = true;
        }

        protected void newUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Register.aspx");
        }
    }
}