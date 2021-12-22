using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Dto.Categories;

namespace MusteriBilgiSistemi.Services
{
    public interface ICategoryRepository
    {
        Result Save(CategoryAddDto instance);
        Result<IList<CategoryListDto>> ListOf();
        Result Delete(object instanceID);
        Result<CategoryListDto> Load(object _categoryId);
        Result Count();
    }
}
