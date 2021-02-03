using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concerete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int  CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public Decimal UnitPrice { get; set; }
        
    }
}
