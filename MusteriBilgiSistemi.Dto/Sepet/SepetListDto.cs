using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgiSistemi.Dto.Sepet
{
    public class SepetListDto
    {
        public int SepetId { get; set; }
        public int UrunId { get; set; }
        public int MusteriId { get; set; }
        public int OdemeTipId { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public bool Onay { get; set; }
        public DateTime? Tarih { get; set; }

        public string UrunAdi { get; set; }
    }
}
