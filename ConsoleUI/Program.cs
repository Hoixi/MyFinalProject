using HoixiBackend.Business.Concrete;
using HoixiBackend.DataAccess.Concrete.EntityFramework;
using System.Runtime.InteropServices;


ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetail();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine("Ürün İsmi : " + product.ProductName + " | Ürün Kategorisi : " + product.CategoryName);
        }
    }

    else
    {
        Console.WriteLine(result.Message);
    }
    
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}