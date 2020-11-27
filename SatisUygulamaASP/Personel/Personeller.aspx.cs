using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Personel
{
    public partial class Personeller : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var personel = db.tblPersonels.ToList();
            Repeater1.DataSource = personel;
            Repeater1.DataBind();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            tblPersonel t = new tblPersonel();
            t.PersonelAd = txtAd.Text;
            t.PersonelSoyad = txtSoyad.Text;
            db.tblPersonels.Add(t);
            db.SaveChanges();

            var personel = db.tblPersonels.ToList();
            Repeater1.DataSource = personel;
            Repeater1.DataBind();
        }
    }
}