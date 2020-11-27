using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Login
{
    public partial class Login : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.tblKullanicis where x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("/Kategoriler.aspx");
            }
            else
            {
                Response.Write("<script>alert('Kullanıcı Yada Şifre Hatalı')</script>");
            }
        }
    }
}