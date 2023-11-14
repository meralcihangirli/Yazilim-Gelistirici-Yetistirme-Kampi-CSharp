// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    private static void Main(string[] args)
    {
        
        ProductManager productManager = new ProductManager (new InMemoryProductDal());
        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
            Console.WriteLine(product.UnitPrice);
        }

    }
}