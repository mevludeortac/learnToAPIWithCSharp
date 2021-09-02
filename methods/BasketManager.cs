using System;
namespace methods
{
    public class BasketManager
    {
        //write to method
        public void Add(Product product) //parametres
        {
            Console.WriteLine("added to basket : " + product.ProductName );
        }
    }
}
