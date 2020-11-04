using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RentACar.Veritabani.Entity;
using RentACar.Veritabani.Model;
using RentACar.Veritabani.EnumType;

namespace RentACar.Veritabani.Islem
{
    public class UrunIslem
    {
        private RentACarEntities _entity = new RentACarEntities();

        public MUrun Getir_UrunBilgileri(int urunId)
        {
            var urunDb = (from u in _entity.Urun
                           where u.UrunId == urunId
                           select new
                           {
                               u.UrunId,
                               u.UrunAd,
                               u.Aciklama,
                               u.UrunResim,
                               u.UrunFiyat
                           }).FirstOrDefault();

            var urun = new MUrun
            {
                UrunId = urunDb.UrunId,
                UrunAd = urunDb.UrunAd,
                Aciklama = urunDb.Aciklama,
                Fiyat_1_3 = Convert.ToDouble((urunDb.UrunFiyat.Where(x=>x.UrunFiyatTip == (int)FiyatTip.Fiyat_1_3).Count() > 0) ? (urunDb.UrunFiyat.Where(x=>x.UrunFiyatTip == (int)FiyatTip.Fiyat_1_3).FirstOrDefault().Fiyat) : 0),
                Fiyat_3_7 = Convert.ToDouble((urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_3_7).Count() > 0) ? (urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_3_7).FirstOrDefault().Fiyat) : 0),
                Fiyat_7_10 = Convert.ToDouble((urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_7_10).Count() > 0) ? (urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_7_10).FirstOrDefault().Fiyat) : 0),
                Fiyat_10_15 = Convert.ToDouble((urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_10_15).Count() > 0) ? (urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_10_15).FirstOrDefault().Fiyat) : 0),
                Fiyat_15_20 = Convert.ToDouble((urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_15_20).Count() > 0) ? (urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_15_20).FirstOrDefault().Fiyat) : 0),
                Fiyat_20_30 = Convert.ToDouble((urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_20_30).Count() > 0) ? (urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_20_30).FirstOrDefault().Fiyat) : 0),
                Fiyat_Aylik = Convert.ToDouble((urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_Aylik).Count() > 0) ? (urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_Aylik).FirstOrDefault().Fiyat) : 0),
                Fiyat_Yillik = Convert.ToDouble((urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_Yillik).Count() > 0) ? (urunDb.UrunFiyat.Where(x => x.UrunFiyatTip == (int)FiyatTip.Fiyat_Yillik).FirstOrDefault().Fiyat) : 0),
                UrunResimPath = (urunDb.UrunResim.Where(x => x.AnaResimMi).Count() > 0) ? urunDb.UrunResim.Where(x => x.AnaResimMi).FirstOrDefault().ResimPath : "Content/images/resimyok.jpg"
            };

            return urun;
        }

        public List<MUrunResim> Getir_UrunResimleri(int urunId)
        {
            var urunResimleri = (from r in _entity.UrunResim
                                 where r.UrunId == urunId
                                 select new MUrunResim
                                 {
                                     UrunId = r.UrunId,
                                     UrunResimId = r.UrunResimId,
                                     UrunResimPath = r.ResimPath
                                 }).ToList();
            return urunResimleri;
        }
    }
}
