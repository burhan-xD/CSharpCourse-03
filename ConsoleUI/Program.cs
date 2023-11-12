
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var item in productManager.GetAllUnitPrice(15, 88))
{
    Console.WriteLine(item.ProductName);
}
