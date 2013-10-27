using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        static DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                welcomeMsg.InnerText += " " + (Session["user"] == null ? "Misafir" : Session["user"].ToString());
                dt.Columns.Clear();
                dt.Columns.Add("baslik", typeof(string));
                dt.Columns.Add("metin", typeof(string));
                dt.Columns.Add("resim", typeof(byte[]));
                dt = new Manager().HaberlerList();
                haberlerTable.DataSource = dt;
                haberlerTable.DataBind();
                haberlerTable_SelectedIndexChanged(sender, e);
            }
        }

        protected void haberlerTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            haberlerImage.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dt.Rows[haberlerTable.SelectedRow.RowIndex]["resim"]);
            haberlerBaslik.Text = dt.Rows[haberlerTable.SelectedRow.RowIndex]["baslik"].ToString();
            haberlerMetin.Text = dt.Rows[haberlerTable.SelectedRow.RowIndex]["metin"].ToString();
        }
    }
}
