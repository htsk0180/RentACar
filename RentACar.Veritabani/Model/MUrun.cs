using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentACar.Veritabani.Model
{
    public class MUrun
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public string Aciklama { get; set; }
        public string UrunResimPath { get; set; }
        public double Fiyat_1_3 { get; set; }
        public double Fiyat_3_7 { get; set; }
        public double Fiyat_7_10 { get; set; }
        public double Fiyat_10_15 { get; set; }
        public double Fiyat_15_20 { get; set; }
        public double Fiyat_20_30 { get; set; }
        public double Fiyat_Aylik { get; set; }
        public double Fiyat_Yillik { get; set; }
        //
        public string StrFiyat_1_3 { get { return Fiyat_1_3.ToString() + " TL"; } }
        public string StrFiyat_3_7 { get { return Fiyat_3_7.ToString() + " TL"; } }
        public string StrFiyat_7_10 { get { return Fiyat_7_10.ToString() + " TL"; } }
        public string StrFiyat_10_15 { get { return Fiyat_10_15.ToString() + " TL"; } }
        public string StrFiyat_15_20 { get { return Fiyat_15_20.ToString() + " TL"; } }
        public string StrFiyat_20_30 { get { return Fiyat_20_30.ToString() + " TL"; } }
        public string StrFiyat_Aylik { get { return Fiyat_Aylik.ToString() + " TL"; } }
        public string StrFiyat_Yillik { get { return Fiyat_Yillik.ToString() + " TL"; } }
    }
}
