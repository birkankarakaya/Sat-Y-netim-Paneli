using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.Tbl_Urun.Where(x => x.Durum == true).ToList();
            var urunler = (from x in db.Tbl_Urun
                           where x.Durum == true
                           select new
                           {
                               x.ID,
                               x.UrunAd,
                               x.UrunMarka,
                               x.Tbl_Kategori.KategoriAd,
                               x.UrunFiyat,
                               x.UrunStok
                           }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}