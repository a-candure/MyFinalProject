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
            ProductManager  productManager= new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}
