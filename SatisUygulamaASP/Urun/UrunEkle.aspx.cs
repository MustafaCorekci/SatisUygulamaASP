using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP.Urun
{
    public partial class UrunEkle : System.Web.UI.Page
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
            }
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            tblUrun t = new tblUrun();
            t.UrunAd = txtUrunAd.Text;
            t.UrunMarka = txtMarka.Text;
            t.UrunKategori = byte.Parse(DropDownList1.SelectedValue);
            t.UrunFiyat = decimal.Parse(txtFiyat.Text);
            t.UrunStok = short.Parse(txtStok.Text);
            t.Durum = true;
            db.tblUruns.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}