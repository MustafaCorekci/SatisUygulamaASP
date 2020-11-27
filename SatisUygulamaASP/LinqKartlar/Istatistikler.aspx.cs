using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.LinqKartlar
{
    public partial class Istatistikler : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUrunSayisi.Text = db.tblUruns.Count().ToString();
            lblMusteriSayisi.Text = db.tblMusteris.Count().ToString();
            lblKasadakiTutar.Text = db.tblSatis.Sum(x => x.Fiyat).ToString();
            lblKategoriSayisi.Text = db.tblKategoris.Count().ToString();
            lblAktifUrunSayisi.Text = db.tblUruns.Count(x => x.Durum == true).ToString();
            lblPasifUrunSayisi.Text = db.tblUruns.Count(x => x.Durum == false).ToString();
            lblFazlaStokluUrun.Text = (from x in db.tblUruns.Where(x => x.Durum == true) orderby x.UrunStok descending select x.UrunAd).FirstOrDefault();
            Label.Text = (from x in db.tblUruns.Where(x => x.Durum == true) orderby x.UrunStok ascending select x.UrunAd).FirstOrDefault();

            var data = db.tblUruns.Where(w => w.Durum == true).GroupBy(u => u.UrunKategori).Select(u => new { u.FirstOrDefault().tblKategori.KategoriAd, adet = u.Count() }).OrderByDescending(o => o.adet).Take(1).ToList();

            lblFazlaKategori.Text = (from item in data select item.KategoriAd).FirstOrDefault();
        }
    }
}