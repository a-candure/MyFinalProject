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

            ListOfAll();
        }

        private static void ListOfAll()
        {
            ProductManager productManager = new ProductManager(new EfProductDal()
                , new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal()); ;
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal()
                , new CategoryManager(new EfCategoryDal()));
            foreach (var product in productManager.GetByUnitPrice(30, 45).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}

