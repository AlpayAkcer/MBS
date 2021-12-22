using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Dto.Sepet;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Orm;

namespace MusteriBilgiSistemi.Services
{
    public class SepetRepository : ISepetRepository
    {
        private MusteriBilgiSistemiEntities _musteriBilgiSistemiEntities;

        public SepetRepository()
        {
            _musteriBilgiSistemiEntities = new MusteriBilgiSistemiEntities();
        }


        public Result Save(SepetAddDto newInstance)
        {
            var result = new Result();
            try
            {
                var saveItem = new Sepet()
                {
                    MusteriId = newInstance.MusteriId,
                    OdemeTipId = newInstance.OdemeTipId,
                    Onay = newInstance.Onay,
                    SiparisTarihi = newInstance.Tarih
                };
                _musteriBilgiSistemiEntities.Sepet.Add(saveItem);
                _musteriBilgiSistemiEntities.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public Result<IList<SepetListDto>> ListOff()
        {
            var result = new Result<IList<SepetListDto>>();
            try
            {
                var listof = from x in _musteriBilgiSistemiEntities.Sepet
                             orderby x.SepetId ascending
                             select new SepetListDto()
                             {
                                 MusteriId = x.MusteriId,
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
    }
}
