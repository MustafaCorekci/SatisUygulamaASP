using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            tblKategori t = new tblKategori();
            t.KategoriAd = txtKategoriAd.Text;
            db.tblKategoris.Add(t);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}