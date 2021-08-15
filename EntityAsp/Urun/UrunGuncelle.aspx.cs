using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //dropdown verilerinin gelmesi
                var kategori = (from x in db.Tbl_Kategori select new { x.ID, x.KategoriAd }).ToList();
                drpKategori.DataTextField = "KategoriAd";
                drpKategori.DataValueField = "ID";
                drpKategori.DataSource = kategori;
                drpKategori.DataBind();



                //ürünün bilgileri
                int id = Convert.ToInt32(Request.QueryString["ID"]);
                var urun = db.Tbl_Urun.Find(id);
                txtUrunAd.Text = urun.UrunAd;
                txtUrunMarka.Text = urun.UrunMarka;
                drpKategori.SelectedValue = urun.UrunKategori.ToString();
                txtUrunFiyat.Text = urun.UrunFiyat.ToString();
                txtUrunStok.Text = urun.UrunStok.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            var urun = db.Tbl_Urun.Find(id);
            urun.UrunAd = txtUrunAd.Text;
            urun.UrunMarka = txtUrunMarka.Text;
            urun.UrunKategori = Convert.ToInt32(drpKategori.Text);
            urun.UrunFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
            urun.UrunStok = Convert.ToInt16(txtUrunStok.Text);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}