using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimciSiniflar
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public int KatagoriId { get; set; }
        public DateTime SatisBaslangicTarihi { get; set; }
        public DateTime SatisBitisTarihi { get; set; }
        public override string ToString()
        {
            return "UrunId: " + UrunId.ToString() + " Urun Adi: " + UrunAdi.ToString() + " Fiyat: " + Fiyat.ToString();
        }

    }
}
