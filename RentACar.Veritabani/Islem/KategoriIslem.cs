using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RentACar.Veritabani.Model;
using RentACar.Veritabani.Entity;

namespace RentACar.Veritabani.Islem
{
    public class KategoriIslem
    {
        private RentACarEntities _entity = new RentACarEntities();


        public List<MKategori_KategoriSf> Getir_Kategoriler()
        {
            List<MKategori_KategoriSf> return_kategoriler = new List<MKategori_KategoriSf>();
            var kategoriler = (from k in _entity.Kategori
                               where
                                   k.Sil == 0
                               select new { k.KategoriId, k.KategoriAd, k.KategoriResim, k.KategoriTanim });

            foreach (var kategori in kategoriler)
            {
                MKategori_KategoriSf listeyeEklenecekKategori = new MKategori_KategoriSf
                {
                    KategoriId = kategori.KategoriId
                };

                if (kategori.KategoriResim != null && kategori.KategoriResim.Count > 0)
                    listeyeEklenecekKategori.KategoriResimPath = kategori.KategoriResim.FirstOrDefault().ResimPath;
                else
                    listeyeEklenecekKategori.KategoriResimPath = "Content/images/resimyok.jpg";

                if (kategori.KategoriTanim != null && kategori.KategoriTanim.Count > 0)
                    listeyeEklenecekKategori.KategoriAd = kategori.KategoriTanim.FirstOrDefault().Ad;
                else
                    listeyeEklenecekKategori.KategoriAd = kategori.KategoriAd;

                return_kategoriler.Add(listeyeEklenecekKategori);
            }


            return return_kategoriler;
        }


        public List<MUrun_KategoriSf> Getir_KategorininUrunleri(int kategoriId)
        {
            List<MUrun_KategoriSf> return_urunler = new List<MUrun_KategoriSf>();
            var urunler = (from u in _entity.Urun
                               where
                                   u.Sil == 0
                               select new { u.UrunId, u.UrunAd, u.UrunResim, u.UrunTanim});

            foreach (var urun in urunler)
            {
                MUrun_KategoriSf listeyeEklenecekUrun = new MUrun_KategoriSf
                {
                    UrunId = urun.UrunId
                };

                if (urun.UrunResim != null && urun.UrunResim.Count > 0)
                    listeyeEklenecekUrun.UrunResimPath = urun.UrunResim.FirstOrDefault().ResimPath;
                else
                    listeyeEklenecekUrun.UrunResimPath = "Content/images/resimyok.jpg";

                if (urun.UrunTanim != null && urun.UrunTanim.Count > 0)
                    listeyeEklenecekUrun.UrunAd = urun.UrunTanim.FirstOrDefault().Ad;
                else
                    listeyeEklenecekUrun.UrunAd = urun.UrunAd;

                return_urunler.Add(listeyeEklenecekUrun);
            }


            return return_urunler;
        }
    }
}
