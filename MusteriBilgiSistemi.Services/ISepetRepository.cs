using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Dto.Sepet;

namespace MusteriBilgiSistemi.Services
{
    public interface ISepetRepository
    {
        Result Save(SepetAddDto newInstance);
        Result<IList<SepetListDto>> ListOff();

    }
}
