using EntityAsp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Urun;
using EntityAsp.Musteri;


namespace EntityAsp.Satis
{
    public partial class Satislar : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var satislar = (from x in db.Tbl_Satis
                            select new
                            {
                                x.ID,
                                URUN = x.Tbl_Urun.UrunAd,
                                PERSONEL = x.Tbl_Personel.AdSoyad,
                                MUSTERI = x.Tbl_Musteri.AdSoyad,
                                FIYAT = x.FIYAT
                            }).ToList();
            Repeater1.DataSource = satislar;
            Repeater1.DataBind();
        }
    }
}