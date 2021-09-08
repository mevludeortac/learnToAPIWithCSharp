using System;

namespace OOPOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //instance1
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 6;
            product1.ProductName = "lamba";
            product1.UnitPrice = 50;
            product1.UnitsInStock = 78;

            //instance2
            Product product2 = new Product { Id = 1, CategoryId = 4, ProductName = "abajur", UnitPrice = 30, UnitsInStock = 45 };

            ProductManager productManager = new ProductManager();
        }  
    }
}
