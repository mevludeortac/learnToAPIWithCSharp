using System;

namespace methods

    //tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
    //dont repeat yourself -dry
    //clean code technics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "pencil";
            product1.ProductPrice = 10;
            product1.Comment = "stylographic pen";

            Product product2 = new Product();
            product2.ProductName = "eraser";
            product2.ProductPrice = 5;
            product2.Comment = "so much power";

            Product[] products = new Product[] { product1, product2 };

            //type-safe : tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.Comment);
                Console.WriteLine("---------------------");
                
            }
            Console.WriteLine("-----------METHODS------------");
            //INSTANCE - class örneği oluşturma işlemi
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);
            


        }
    }
}
