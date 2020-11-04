using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RentACar.Veritabani.Islem;

namespace RentACar.Web
{
    public partial class Arac : System.Web.UI.Page
    {
        private UrunIslem _urunIslem = new UrunIslem();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int urunId = Convert.ToInt32(Request.QueryString["aracid"]);
                var urun = _urunIslem.Getir_UrunBilgileri(urunId);
                lbBaslik.Text = urun.UrunAd;
                lbTeknikOzellikler.Text = urun.Aciklama;
                lbFiyat_1_3.Text = urun.StrFiyat_1_3;
                lbFiyat_3_7.Text = urun.StrFiyat_3_7;
                lbFiyat_7_10.Text = urun.StrFiyat_7_10;
                lbFiyat_10_15.Text = urun.StrFiyat_10_15;
                lbFiyat_15_20.Text = urun.StrFiyat_15_20;
                lbFiyat_20_30.Text = urun.StrFiyat_20_30;
                lbFiyat_Aylik.Text = urun.StrFiyat_Aylik;
                lbFiyat_Yillik.Text = urun.StrFiyat_Yillik;
                imgArac.ImageUrl = urun.UrunResimPath;
            }
            catch { }
        }
    }
}