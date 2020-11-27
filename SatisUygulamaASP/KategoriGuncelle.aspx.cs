using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = int.Parse(Request.QueryString["KategoriID"]);
                txtKategoriID.Text = id.ToString();
                var ktgr = db.tblKategoris.Find(id);
                txtKategoriAd.Text = ktgr.KategoriAd;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["KategoriID"]);
            var ktgr = db.tblKategoris.Find(id);
            ktgr.KategoriAd = txtKategoriAd.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}