using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
                Response.Redirect("~/Default.aspx");
            username.Focus();
        }

        protected void register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
                errMsg.Text = "Kullanıcı Adı boş olamaz";
            else if (string.IsNullOrEmpty(password.Text))
                errMsg.Text = "Şifre boş olamaz";
            else if (password.Text != passwordRepeat.Text)
                errMsg.Text = "Şifreler eşleşmelidir";
            else if (new Manager().CreateUser(username.Text, password.Text, email.Text))
            {
                Session.Add("user", username.Text);
                Response.Redirect("~/Default.aspx");
            }
            else
                errMsg.Text = "Kullanıcı mevcut";
        }
    }
}