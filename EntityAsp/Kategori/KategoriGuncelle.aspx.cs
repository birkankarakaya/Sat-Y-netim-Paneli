using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtID.Enabled = false;
                int id = Convert.ToInt32(Request.QueryString["ID"]);
                txtID.Text = id.ToString();
                var kategori = db.Tbl_Kategori.Find(id);
                txtAd.Text = kategori.KategoriAd;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            var kategori = db.Tbl_Kategori.Find(id);
            kategori.KategoriAd = txtAd.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}