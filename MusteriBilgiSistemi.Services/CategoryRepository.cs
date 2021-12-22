using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Dto.Categories;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Orm;

namespace MusteriBilgiSistemi.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private MusteriBilgiSistemiEntities _musteriBilgiSistemiEntities;

        public CategoryRepository()
        {
            _musteriBilgiSistemiEntities = new MusteriBilgiSistemiEntities();
        }

        public Result Save(CategoryAddDto instance)
        {
            var result = new Result();
            try
            {
                var saveItem = new Categories()
                {
                    Description = instance.Description,
                    CategoryName = instance.CategoryName,
                    Onay = instance.Onay

                };
                _musteriBilgiSistemiEntities.Categories.Add(saveItem);
                _musteriBilgiSistemiEntities.SaveChanges();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return result;
        }

        public Result<IList<CategoryListDto>> ListOf()
        {
            var result = new Result<IList<CategoryListDto>>();
            try
            {
                var listof = from x in _musteriBilgiSistemiEntities.Categories
                             orderby x.CategoryId ascending
                             select new CategoryListDto()
                             {
                                 CategoryName = x.CategoryName,
                                 Description = x.Description,
                                 CategoryId = x.CategoryId,
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
            throw new NotImplementedException();
        }

        public Result<CategoryListDto> Load(object _categoryId)
        {
            throw new NotImplementedException();
        }

        public Result Count()
        {
            throw new NotImplementedException();
        }
    }
}
