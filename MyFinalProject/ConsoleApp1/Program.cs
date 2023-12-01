// See https://aka.ms/new-console-template for more information
using DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Business.Concrete;
using Core.Utilities.Results;
using System.ComponentModel.Design;

class Program
{
    private static void Main(string[] args)
    {
        //ProductTest();

        //CategoryTest();

    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll().Data)
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    //private static void ProductTest()
    //{
    //    ProductManager productManager = new ProductManager(new EfProductDal());
    //    //Console.WriteLine("sayıgir");
    //    //int sayi = Convert.ToInt32(Console.ReadLine());

    //    var result = productManager.GetProductDetails();

    //    if (result.Success == true)
    //    {
    //        foreach (var product in result.Data)
    //        {
    //            Console.WriteLine(product.ProductName + " / " + product.CategoryName);

    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine(result.Message);
    //    }


    //}
}