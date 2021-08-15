using EntityAsp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityAsp.Satis
{
    public partial class YeniSatis : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.Tbl_Urun select new { x.ID, x.UrunAd }).ToList();
                DropDownList1.DataTextField = "UrunAd";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var mus = (from x in db.Tbl_Musteri
                           select new
                           {
                               x.ID,
                               ADSOYAD = x.AdSoyad
                           }).ToList();
                DropDownList2.DataTextField = "AdSoyad";
                DropDownList2.DataValueField = "ID";
                DropDownList2.DataSource = mus;
                DropDownList2.DataBind();

                var per = (from x in db.Tbl_Personel select new { x.ID, x.AdSoyad }).ToList();
                DropDownList3.DataTextField = "AdSoyad";
                DropDownList3.DataValueField = "ID";
                DropDownList3.DataSource = per;
                DropDownList3.DataBind();
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Satis t = new Tbl_Satis();
            t.MUSTERI = int.Parse(DropDownList2.SelectedValue);
            t.URUN = int.Parse(DropDownList1.SelectedValue);
            t.PERSONEL = byte.Parse(DropDownList3.SelectedValue);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            db.Tbl_Satis.Add(t);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");
        }
    }
}