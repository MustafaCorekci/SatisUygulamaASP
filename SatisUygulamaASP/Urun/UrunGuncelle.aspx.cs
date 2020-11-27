using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var ktgr = (from x in db.tblKategoris
                            select new
                            {
                                x.KategoriID,
                                x.KategoriAd
                            }).ToList();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = ktgr;
                DropDownList1.DataBind();

                int id = int.Parse(Request.QueryString["UrunID"]);
                var urun = db.tblUruns.Find(id);
                txtUrunAd.Text = urun.UrunAd;
                txtMarka.Text = urun.UrunMarka;
                txtFiyat.Text = urun.UrunFiyat.ToString();
                txtStok.Text = urun.UrunStok.ToString();
                DropDownList1.SelectedValue = urun.UrunKategori.ToString();
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["UrunID"]);
            var urun = db.tblUruns.Find(id);
            urun.UrunAd = txtUrunAd.Text;
            urun.UrunMarka = txtMarka.Text;
            urun.UrunFiyat = decimal.Parse(txtFiyat.Text);
            urun.UrunStok = short.Parse(txtStok.Text);
            urun.UrunKategori = byte.Parse(DropDownList1.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}