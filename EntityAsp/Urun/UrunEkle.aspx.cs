using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Urun
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var kategori = (from x in db.Tbl_Kategori select new { x.ID, x.KategoriAd }).ToList();
                drpKategori.DataTextField = "KategoriAd";
                drpKategori.DataValueField = "ID";
                drpKategori.DataSource = kategori;
                drpKategori.DataBind();
            }
            
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.UrunAd = txtUrunAd.Text;
            t.UrunMarka = txtUrunMarka.Text;
            t.UrunKategori = Convert.ToInt32(drpKategori.SelectedValue);
            t.UrunFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            t.UrunStok = Convert.ToInt16(txtUrunStok.Text);
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}