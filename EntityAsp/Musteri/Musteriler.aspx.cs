using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Musteri.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Tbl_Musteri tbl = new Tbl_Musteri();
                tbl.AdSoyad = TextBox1.Text;
                db.Tbl_Musteri.Add(tbl);
                db.SaveChanges();
            }
            
        }
    }
}