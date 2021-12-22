using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgiSistemi.Dto.Musteriler
{
    public class MusteriAddDto
    {
        public MusteriAddDto()
        {
            MusteriAdi = "Müşteri Adını Giriniz";
            FirmaAdi = "Firma Bilgisini Giriniz";
        }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public DateTime? Tarih { get; set; }
        public bool Onay { get; set; }
    }
}
