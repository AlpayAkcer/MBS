using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Dto.Urunler;

namespace MusteriBilgiSistemi.Services
{
    public interface IProductRepository
    {
        Result Save(ProductAddDto instance);
        Result<IList<ProductListDto>> ListOf();
        Result Delete(object instanceID);
        Result<ProductListDto> Load(object _productId);
        Result Count();
    }
}
