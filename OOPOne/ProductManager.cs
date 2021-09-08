using System;
namespace OOPOne
{
    public class ProductManager
    {
        int num1 = 67;
        int num2 = 78;

        //elde edeceğimiz sonuç belli bi veri tipi döndürüyorsa int tipinde tanımlarız ve eğer bu sonucun sadece ekrana yazdırmakla kalmayıp başka bi yerde kullanmak istiyorsak return kullanıyoruz
        public int Topla(int num1, int num2)
        {
            return num1 + num2;
        }

        //elde edeceğimiz sonucu sadece yazdırmak istiyorsak  void kullanır ve return ettirmeyiz
        //void: git-yap-bitir
        public void Topla2(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }


}
