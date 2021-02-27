using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concerete;

namespace DataAccess.Concerete.EntityFramework
{
    public class EfOrderDal :EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
        
    }
}