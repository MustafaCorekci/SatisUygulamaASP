using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        void Listele()
        {
            var musteri = db.tblMusteris.ToList();
            Repeater1.DataSource = musteri;
            Repeater1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Listele();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            tblMusteri t = new tblMusteri();
            t.MusteriAd = txtAd.Text;
            t.MusteriSoyad = txtSoyad.Text;
            db.tblMusteris.Add(t);
            db.SaveChanges();
            Listele();
        }
    }
}