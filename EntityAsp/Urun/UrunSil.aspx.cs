using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            var urun = db.Tbl_Urun.Find(id);
            urun.Durum = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}