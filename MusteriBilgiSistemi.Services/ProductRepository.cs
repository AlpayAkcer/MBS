using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriBilgiSistemi.Dto.Urunler;
using MusteriBilgiSistemi.Common;
using MusteriBilgiSistemi.Orm;

namespace MusteriBilgiSistemi.Services
{
    public class ProductRepository : IProductRepository
    {
        private MusteriBilgiSistemiEntities _musteriBilgiSistemiEntities;

        public ProductRepository()
        {
            _musteriBilgiSistemiEntities = new MusteriBilgiSistemiEntities();
        }

        public Result Save(ProductAddDto instance)
        {
            var result = new Result();

            try
            {
                var saveItem = new Products()
                {
                    CategoryId = instance.CategoryId,
                    Description = instance.Description,
                    ProductName = instance.ProductName,
                    Tarih = instance.Tarih,
                    UnitInStock = Convert.ToInt16(instance.UnitsInStock),
                    UnitPrice = instance.UnitPrice,
                    Onay = instance.Onay
                };

                _musteriBilgiSistemiEntities.Products.Add(saveItem);
                _musteriBilgiSistemiEntities.SaveChanges();
            }

            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return result;
        }
        public Result<IList<ProductListDto>> ListOf()
        {
            var result = new Result<IList<ProductListDto>>();
            try
            {
                var listof = from x in _musteriBilgiSistemiEntities.Products
                             orderby x.ProductId ascending
                             select new ProductListDto()
                             {
                                 ProductId = x.ProductId,
                                 ProductName = x.ProductName,
                                 CategoryId = x.Categories.CategoryId,
                                 Onay = (bool)x.Onay.Value,
                                 Description = x.Description,
                                 Tarih = x.Tarih,
                                 UnitPrice = x.UnitPrice.Value,
                                 UnitsInStock = x.UnitInStock.Value
                             };

                _musteriBilgiSistemiEntities.SaveChanges();
                result.TransactionResult = listof.ToList();
                result.IsSucceeded = true;
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return result;
        }

        public Result Delete(object instanceID)
        {
            var result = new Result();
            try
            {
                var selectedProduct = _musteriBilgiSistemiEntities.Products.FirstOrDefault(x => x.ProductId == (int)instanceID);
                if (selectedProduct != null)
                {
                    _musteriBilgiSistemiEntities.Products.Remove(selectedProduct);
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

        public Result<ProductListDto> Load(object _productId)
        {
            var result = new Result<ProductListDto>();
            try
            {
                var selectedProduct = _musteriBilgiSistemiEntities.Products.FirstOrDefault(x => x.ProductId == (int)_productId);
                if (selectedProduct != null)
                {
                    var retval = new ProductListDto()
                    {
                        CategoryId = selectedProduct.Categories.CategoryId,
                        ProductName = selectedProduct.ProductName,
                        Tarih = selectedProduct.Tarih,
                        ProductId = selectedProduct.ProductId,
                        UnitPrice = selectedProduct.UnitPrice.Value,
                        UnitsInStock = selectedProduct.UnitInStock.Value,
                        CategoryName = selectedProduct.Categories.CategoryName,
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
