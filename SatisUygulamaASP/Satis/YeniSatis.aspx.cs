using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Satis
{
    public partial class YeniSatis : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // Ürünlerin verilerini DropDowna çekme
                var urun = (from x in db.tblUruns
                            where x.Durum == true
                            select new
                            {
                                x.UrunAd,
                                x.UrunID
                            }).ToList();
                ddlUrun.DataTextField = "UrunAd";
                ddlUrun.DataValueField = "UrunID";
                ddlUrun.DataSource = urun;
                ddlUrun.DataBind();

                // Müşterilerin verilerini DropDowna çekme
                var musteri = (from x in db.tblMusteris
                               select new
                               {
                                   x.MusteriID,
                                   AdSoyad = x.MusteriAd + " " + x.MusteriSoyad
                               }).ToList();
                ddlMusteri.DataTextField = "AdSoyad";
                ddlMusteri.DataValueField = "MusteriID";
                ddlMusteri.DataSource = musteri;
                ddlMusteri.DataBind();

                // Personellerin verilerini DropDowna çekme
                var personel = (from x in db.tblPersonels
                                select new
                                {
                                    x.PersonelID,
                                    AdSoyad = x.PersonelAd + " " + x.PersonelSoyad
                                }).ToList();
                ddlPersonel.DataTextField = "AdSoyad";
                ddlPersonel.DataValueField = "PersonelID";
                ddlPersonel.DataSource = personel;
                ddlPersonel.DataBind();
            }
        }

        protected void ddlUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(ddlUrun.SelectedValue);
            var urun = db.tblUruns.Find(id);
            txtFiyat.Text = urun.UrunFiyat.ToString();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            tblSati t = new tblSati();
            t.Musteri = int.Parse(ddlMusteri.SelectedValue);
            t.Urun = int.Parse(ddlUrun.SelectedValue);
            t.Personel = byte.Parse(ddlPersonel.SelectedValue);
            t.Fiyat = decimal.Parse(txtFiyat.Text);
            db.tblSatis.Add(t);
            db.SaveChanges();
            Response.Redirect("SatisListesi.aspx");
        }
    }
}