// See https://aka.ms/new-console-template for more information
using DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Business.Concrete;

class Program
{
    private static void Main(string[] args)
    {
        ProductTest();

        //CategoryTest();

    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        //Console.WriteLine("sayıgir");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        foreach (var product in productManager.GetProductDetails())
        {
            Console.WriteLine(product.ProductName + " / " +product.CategoryName);

        }
    }
}