using System;
namespace OOP3
{
    //inheritance'den sonra implement ettikten sonra interfaceimizdeki bütün operasyonları getiriyor

    public class TransportCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("konut kredisi toplam borç hesaplandı");
        }
    }
}
