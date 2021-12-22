using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Dto.Musteriler;
using MusteriBilgiSistemi.Orm;

namespace MusteriBilgiSistemi.Services
{
    public class MusteriRepository : IMusteriRepository
    {
        MusteriBilgiSistemiEntities _musteriBilgiSistemiEntities = new MusteriBilgiSistemiEntities();

        public MusteriRepository()
        {
            _musteriBilgiSistemiEntities = new MusteriBilgiSistemiEntities();
        }

        public Result Save(MusteriAddDto instance)
        {
            var result = new Result();
            try
            {
                var saveItem = new Musteriler()
                {
                    MusteriAdi = instance.MusteriAdi,
                    FirmaAdi = instance.FirmaAdi,
                    Adres = instance.Adres,
                    MusteriSoyadi = instance.MusteriSoyadi,
                    Onay = instance.Onay,
                    Tarih = instance.Tarih,
                    Telefon = instance.Telefon
                };
                _musteriBilgiSistemiEntities.Musteriler.Add(saveItem);
                _musteriBilgiSistemiEntities.SaveChanges();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return result;
        }

        public Result<IList<MusteriListDto>> ListOf()
        {
            var result = new Result<IList<MusteriListDto>>();
            try
            {
                var listof = from x in _musteriBilgiSistemiEntities.Musteriler
                             orderby x.MusteriAdi ascending
                             select new MusteriListDto()
                             {
                                 MusteriId = x.MusteriId,
                                 Adres = x.Adres,
                                 Telefon = x.Telefon,
                                 FirmaAdi = x.FirmaAdi,
                                 MusteriAdi = x.MusteriAdi,
                                 MusteriSoyadi = x.MusteriSoyadi,
                                 Tarih = x.Tarih,
                                 Onay = x.Onay.Value
                             };
                _musteriBilgiSistemiEntities.SaveChanges();
                result.TransactionResult = listof.ToList();
                result.IsSucceeded = true;


            }
            catch (Exception)
            {
                result.IsSucceeded = false;

            }
            return result;
        }

        public Result Delete(object instanceID)
        {
            var result = new Result();
            try
            {
                var selectedProduct = _musteriBilgiSistemiEntities.Musteriler.FirstOrDefault(x => x.MusteriId == (int)instanceID);
                if (selectedProduct != null)
                {
                    _musteriBilgiSistemiEntities.Musteriler.Remove(selectedProduct);
                    //selectedProduct.Bit = 0;
                }
                _musteriBilgiSistemiEntities.SaveChanges();
                result.IsSucceeded = true;
            }
            catch (Exception)
            {
                result.IsSucceeded = false;

            }
            return result;
        }

        public Result<MusteriListDto> Load(object _musteriId)
        {
            var result = new Result<MusteriListDto>();
            try
            {
                var selectedProduct = _musteriBilgiSistemiEntities.Musteriler.FirstOrDefault(x => x.MusteriId == (int)_musteriId);
                if (selectedProduct != null)
                {
                    var retval = new MusteriListDto()
                    {
                        MusteriAdi = selectedProduct.MusteriAdi,
                        MusteriSoyadi = selectedProduct.MusteriSoyadi,
                        FirmaAdi = selectedProduct.FirmaAdi,
                        Adres = selectedProduct.Adres,
                        Tarih = selectedProduct.Tarih,
                        Telefon = selectedProduct.Telefon,
                        Onay = selectedProduct.Onay.Value
                    };
                    result.TransactionResult = retval;
                }
                _musteriBilgiSistemiEntities.SaveChanges();
                result.IsSucceeded = true;

            }
            catch (Exception)
            {

                result.IsSucceeded = false;

            }
            return result;
        }

        public Result Count()
        {
            throw new NotImplementedException();
        }
    }
}
