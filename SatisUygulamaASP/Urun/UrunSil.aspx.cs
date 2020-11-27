using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UrunID"]);
            var urun = db.tblUruns.Find(id);
            urun.Durum = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}