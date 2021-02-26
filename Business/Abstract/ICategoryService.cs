using System.Collections.Generic;
using Core.Utilities.results;
using Entities.Concerete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);

    }
}