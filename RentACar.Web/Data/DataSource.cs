using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentACar.Veritabani.Model;
using RentACar.Veritabani.Islem;

namespace RentACar.Web.Data
{
    public class DataSource
    {
        private static KategoriIslem _kategoriIslem = new KategoriIslem();
        private static UrunIslem _urunIslem = new UrunIslem();


        public static List<MKategori_KategoriSf> Kategoriler()
        {
            return _kategoriIslem.Getir_Kategoriler();
        }
        public static List<MUrun_KategoriSf> KategorininUrunleri(int kategoriId)
        {
            return _kategoriIslem.Getir_KategorininUrunleri(kategoriId);
        }
        public static List<MUrunResim> UrunResimleri(int urunId)
        {
            return _urunIslem.Getir_UrunResimleri(urunId);
        }
    }
}