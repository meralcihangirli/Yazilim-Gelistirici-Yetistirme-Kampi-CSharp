// See https://aka.ms/new-console-template for more information
using DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;

class Program
{
    private static void Main(string[] args)
    {

        ProductManager productManager = new ProductManager(new EfProductDal());
        foreach (var product in productManager.GetAllByCategoryId(2))
        {
            Console.WriteLine(product.ProductName);
           
        }

    }
}