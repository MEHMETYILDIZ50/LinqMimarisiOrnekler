
//sy 860
using YardimciSiniflar;

List<Kategori> kategoriler = Helper.KategorileriGetir();
List<Urun> urunler = Helper.UrunleriGetir();

var sonuclar1 = from c in urunler
                where c.KatagoriId == 1 && c.Fiyat >15
                select c;

foreach (var k in sonuclar1)
    Console.WriteLine(k);
Console.WriteLine( "-------------------------");
var sonuclar2 = from c in urunler
                where c.KatagoriId == 1 && c.Fiyat > 15
                select new { Ad = c.UrunAdi.ToUpper(), c.KatagoriId, KDVli = c.Fiyat * 1.18 };

foreach (var k in sonuclar2)
    Console.WriteLine(k);
Console.WriteLine("----------------------------");
string[] cumleler = { "Merhaba Ali", "Ben Geldim", "Yarın maç var", "C# 11 çok iyi yapmışlar" };
var kelimeler =from cumle in cumleler
               from kelime in cumle.Split(' ')
               where kelime.Length > 4
               select kelime;
foreach (var k in kelimeler)
    Console.WriteLine(k);
Console.WriteLine("------------------------");
var sonuclar4 = (from c in urunler
                 select c).Take(3);
foreach (var k in sonuclar4)
    Console.WriteLine(k);
Console.WriteLine("------------------------");
var sonuclar5 = (from c in urunler
                 select c).Skip(5);
foreach (var k in sonuclar5)
    Console.WriteLine(k);
Console.WriteLine("------------------------");
var sonuclar6 = from urun in urunler
                orderby urun.UrunAdi.Length descending
                select urun.UrunAdi;
foreach (var k in sonuclar6)
    Console.WriteLine(k);
Console.WriteLine("------------------------");
var sonuclar8 = from urun in urunler
                orderby urun.KatagoriId, urun.Fiyat descending
                select new { urun.KatagoriId, urun.Fiyat, urun.UrunAdi };
foreach (var k in sonuclar8)
    Console.WriteLine(k);
Console.WriteLine("------------------------");
var sonuclar9 = from urun in urunler
                orderby urun.KatagoriId 
                group urun by urun.KatagoriId into grup
                select new {grup.Key, Urunler =grup, Adet=grup.Count()};
foreach (var k in sonuclar9)
{
    Console.WriteLine("Kategorisi " + k.Key + " olan Ürünler.Toplam " + k.Adet + " ürün.");
    foreach (var urun in k.Urunler)
        Console.WriteLine("      "+ urun.UrunAdi);
}
Console.WriteLine("------------------------");
var sonuclar10 =  from urun in urunler
                  orderby urun.KatagoriId
                  group urun by new {k1=urun.KatagoriId, k2= urun.SatisBaslangicTarihi.Year}
                  into grup orderby grup.Key.k1
                  select new {grup.Key.k1, grup.Key.k2, Urunler=grup, Adet=grup.Count()};
foreach (var k in sonuclar10)
{
    Console.WriteLine("Kategorisi "+k.k1 + " Satış Yılı: "+k.k2 + " olan ürünler\n");
    foreach (var item in k.Urunler)
    {
        Console.WriteLine("  " + item.UrunAdi);
    }
    Console.WriteLine();
}
Console.WriteLine("-------------------");
var sonuclar11 = from urun in urunler
                 group urun by urun.KatagoriId into grup
                 select new { grup.Key, Urunler = grup, ToplamFiyat = grup.Sum(u => u.Fiyat) };
foreach (var k in sonuclar11)
    Console.WriteLine("Kategorisi: " + k.Key + " olanların toplamı: " + k.ToplamFiyat);

