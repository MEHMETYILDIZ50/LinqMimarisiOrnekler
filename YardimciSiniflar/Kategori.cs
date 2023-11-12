using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimciSiniflar
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public override string ToString()
        {
            return "Kategori ID: " + KategoriId.ToString() + " Kategori: " + KategoriAdi.ToString();
        }
    }
}
