using System;
using Business.Concerete;
using DataAccess.Concerete.EntityFramework;
using DataAccess.Concerete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }




        private static void CategoryTest()
        {
            CategoryManager productManager = new CategoryManager(new EfCategoryDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(30, 45))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}

