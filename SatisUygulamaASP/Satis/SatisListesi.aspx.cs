using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Satis
{
    public partial class SatisListesi : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var satisler = (from x in db.tblSatis
                            select new
                            {
                                x.SatisID,
                                x.tblUrun.UrunAd,
                                personel = x.tblPersonel.PersonelAd + " " + x.tblPersonel.PersonelSoyad,
                                musteri = x.tblMusteri.MusteriAd + " " + x.tblMusteri.MusteriSoyad,
                                x.Fiyat
                            }).ToList();

            Repeater1.DataSource = satisler;
            Repeater1.DataBind();
        }
    }
}