using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //var degerler = db.tblUruns.Where(x => x.Durum == true).ToList();
            var degerler = (from x in db.tblUruns
                            where x.Durum == true
                            select new
                            {
                                x.UrunID,
                                x.UrunAd,
                                x.UrunMarka,
                                x.tblKategori.KategoriAd,
                                x.UrunFiyat,
                                x.UrunStok,
                            }).ToList();
                            
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}