using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SatisUygulamaASP.Entity;

namespace SatisUygulamaASP
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        dbSatisASPEntities db = new dbSatisASPEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.tblKategoris.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}