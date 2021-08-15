using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp.LinqKartlar
{
    public partial class Istatistik : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Tbl_Urun.Count().ToString();
            Label2.Text = db.Tbl_Musteri.Count().ToString();
            Label3.Text = db.Tbl_Satis.Sum(x => x.FIYAT).ToString();
            Label4.Text = db.Tbl_Kategori.Count().ToString();
            Label5.Text = db.Tbl_Urun.Count(x => x.Durum == true).ToString();
            Label6.Text = db.Tbl_Urun.Count(x => x.Durum == false).ToString();
            Label7.Text = (from x in db.Tbl_Urun orderby x.UrunStok descending select x.UrunAd).FirstOrDefault();
        }
    }
}