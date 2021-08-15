using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAsp.Entity;

namespace EntityAsp
{
    public partial class Login : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var sorgu = from x in db.Tbl_Admin where x.Kullanici == TxtKullaniciAd.Text && x.Sifre == TxtSifre.Text select x;
                if (sorgu.Any())
                {
                    Response.Redirect("/Kategoriler/Kategoriler.Aspx");
                }
                else
                {
                    Response.Write("Hatalı Bilgi Girişi");
                }
            }
            
        }
    }
}