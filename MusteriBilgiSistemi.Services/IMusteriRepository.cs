using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Dto.Musteriler;

namespace MusteriBilgiSistemi.Services
{
    public interface IMusteriRepository
    {
        Result Save(MusteriAddDto instance);
        Result<IList<MusteriListDto>> ListOf();
        Result Delete(object instanceID);
        Result<MusteriListDto> Load(object _musteriId);
        Result Count();
    }
}
