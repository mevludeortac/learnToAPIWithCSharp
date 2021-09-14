using System;
namespace OOP3
{
    //inheritance'den sonra implement ettikten sonra interfaceimizdeki bütün operasyonları getiriyor
    public class PersonalFinanceCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("ihtiyaç kredisi toplam borç hesaplandı");
        }
    }
}
