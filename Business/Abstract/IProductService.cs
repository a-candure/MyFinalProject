using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concerete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

    }
}
