using System.Linq;

class Program
{
    private static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
       {
           new Category {CategoryId = 1,CategoryName="Bilgisayar"},
           new Category {CategoryId = 2,CategoryName="Telefon"}
       };

        List<Product> products = new List<Product>
        {
            new Product {ProdutcId=1, CategoryId = 1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitInStock=5},
            new Product {ProdutcId=2, CategoryId = 1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=8000,UnitInStock=3},
            new Product {ProdutcId=3, CategoryId = 1,ProductName="HP Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=6000,UnitInStock=2},
            new Product {ProdutcId=4, CategoryId = 2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitInStock=15},
            new Product {ProdutcId=5, CategoryId = 2,ProductName="Apple Telefon",QuantityPerUnit="32 GB Ram",UnitPrice=8000,UnitInStock=5},
        };




        var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }

        GetProducts(products);

    }
    static List<Product> GetProducts(List <Product> products)
    {
        List <Product> filteredProducts=new List<Product>();
        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitInStock > 3)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;    
    }

    static List<Product> GetProductsLinq(List<Product> products)
    {
        return products.Where(product=>product.UnitPrice >5000 && product.UnitInStock > 3).ToList();
    }


}




class Product
{
    public int ProdutcId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public int UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}