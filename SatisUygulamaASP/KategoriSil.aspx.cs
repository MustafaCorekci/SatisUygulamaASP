using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["KategoriID"]);
            var sil = db.tblKategoris.Find(id);
            db.tblKategoris.Remove(sil);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}