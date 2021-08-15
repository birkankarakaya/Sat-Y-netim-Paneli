using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPDBEntities db = new ASPDBEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var p = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(p);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}