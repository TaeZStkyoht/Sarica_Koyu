using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.IO.Compression;
using System.Data;
using System.Text;
using System.Configuration;

namespace WebApplication1
{
    public class Manager
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlServer"].ConnectionString);

        public Manager()
        {
            try
            {
                if (con != null)
                    con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ~Manager()
        {
            try
            {
                if (con != null)
                    con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UserControl(string userName, string password)
        {
            try
            {
                return new MySqlCommand("SELECT sifre FROM uyeler WHERE kullanici_adi='" + userName + "'", con).ExecuteScalar().ToString().Equals(password);
            }
            catch(Exception)
            {
                return false;
            }
        }

        bool UserExists(string userName)
        {
            try
            {
                return new MySqlCommand("SELECT 58 FROM uyeler WHERE kullanici_adi='" + userName + "'", con).ExecuteScalar() != null;
            }
            catch(Exception)
            {
                return true;
            }
        }

        public bool CreateUser(string username, string password, string email)
        {
            try
            {
                if (UserExists(username))
                    return false;
                new MySqlCommand("INSERT INTO uyeler (kullanici_adi, sifre, email) VALUES ('" + username + "', '" + password + "', '" + email + "')", con).ExecuteNonQuery();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public DataTable HaberlerList()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("baslik", typeof(string));
                dt.Columns.Add("metin", typeof(string));
                dt.Columns.Add("resim", typeof(byte[]));
                new MySqlDataAdapter("SELECT * FROM haberler", con).Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
    }
}
