using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ASPDBEntities db = new ASPDBEntities();
            Tbl_Kategori tbl = new Tbl_Kategori();
            tbl.KategoriAd = TextBox1.Text;
            db.Tbl_Kategori.Add(tbl);
            db.SaveChanges();

        }
    }
}