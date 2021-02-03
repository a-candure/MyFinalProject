using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concerete.InMemory;
using Entities.Concerete;

namespace Business.Concerete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //Yetkisi var mı?

            return _productDal.GetAll();
            
        }
    }
}