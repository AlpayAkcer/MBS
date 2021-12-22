using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgiSistemi.Dto.Urunler
{
    public class ProductAddDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Int16 UnitsInStock { get; set; }
        public Decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public bool Onay { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
