using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimciSiniflar
{
    public class Helper
    {
        public static List<Urun> UrunleriGetir()
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){UrunId = 1, UrunAdi="Coca Cola", KatagoriId=2, Fiyat=3, SatisBaslangicTarihi=new DateTime(2008,3,1), SatisBitisTarihi=new DateTime(2008,4,13)},
                new Urun(){UrunId = 1, UrunAdi="Masa", KatagoriId=6, Fiyat=300, SatisBaslangicTarihi=new DateTime(2007,12,3), SatisBitisTarihi=new DateTime(2008,1,3)},
                new Urun(){UrunId = 1, UrunAdi="C#", KatagoriId=1, Fiyat=49, SatisBaslangicTarihi=new DateTime(2005,12,3), SatisBitisTarihi=new DateTime(2007,1,3)},
                new Urun(){UrunId = 1, UrunAdi="VB.Net", KatagoriId=1, Fiyat=25, SatisBaslangicTarihi=new DateTime(2007,1,3), SatisBitisTarihi=new DateTime(2007,4,3)},
                new Urun(){UrunId = 4, UrunAdi="MeyveSuyu", KatagoriId=2, Fiyat=5, SatisBaslangicTarihi=new DateTime(2006,1,3), SatisBitisTarihi=new DateTime(2008,4,3)},
                new Urun(){UrunId = 5, UrunAdi="Buzdolabı", KatagoriId=4, Fiyat=800, SatisBaslangicTarihi=new DateTime(2008,1,13), SatisBitisTarihi=new DateTime(2008,4,23)},
                new Urun(){UrunId = 8, UrunAdi="Dell Bilgisayar", KatagoriId=3, Fiyat=1200, SatisBaslangicTarihi=new DateTime(2008,3,13), SatisBitisTarihi=new DateTime(2008,9,23)},
                new Urun(){UrunId = 54, UrunAdi="Hesap Makinası", KatagoriId=3, Fiyat=300, SatisBaslangicTarihi=new DateTime(2006,3,13), SatisBitisTarihi=new DateTime(2009,9,23)},
                new Urun(){UrunId = 32, UrunAdi="Koltuk Takımı", KatagoriId=6, Fiyat=3500, SatisBaslangicTarihi=new DateTime(2008,2,13), SatisBitisTarihi=new DateTime(2009,6,23)},
                new Urun(){UrunId = 54, UrunAdi="TC Anayasa", KatagoriId=1, Fiyat=15, SatisBaslangicTarihi=new DateTime(2005,2,13), SatisBitisTarihi=new DateTime(2005,6,23)},
                new Urun(){UrunId = 12, UrunAdi="Pocket PC", KatagoriId=3, Fiyat=990, SatisBaslangicTarihi=new DateTime(2005,1,13), SatisBitisTarihi=new DateTime(2006,11,6)},
                new Urun(){UrunId = 10, UrunAdi="XML Kitabı", KatagoriId=1, Fiyat=38, SatisBaslangicTarihi=new DateTime(2008,1,1), SatisBitisTarihi=new DateTime(2008,11,9)},
            };
            return urunler;
        }
        public  static List<Kategori> KategorileriGetir()
        { 
            List<Kategori> kategoriler= new List<Kategori>()
            {  
                new Kategori{KategoriAdi="Kitaplar", KategoriId=1},
                new Kategori{KategoriAdi="İçecekler", KategoriId=2},
                new Kategori{KategoriAdi="Elektronik", KategoriId=3},
                new Kategori{KategoriAdi="Beyaz Eşya", KategoriId=4},
                new Kategori{KategoriAdi="Mobilya", KategoriId=6},
//                new Kategori{KategoriAdi="DVD Medya", KategoriId=7},

            };
            return null;
        }

    }
}
