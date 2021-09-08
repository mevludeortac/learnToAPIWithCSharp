using System;
using System.Collections.Generic;

namespace Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //dizilere sonradan eleman eklediğimizde ilk tanımladığımız dizinin içerisini boşaltmış son eklediğimiz veriyle içerisini yeniden doldurmaya başlamış oluruz.
            //o yüzden dizi kullanmak yerine list kullanabilir ve içerisine istediğimiz gibi eleman ekleyebiliriz
            List<string> names = new List<string> { "mülkiye", "mehmet", "sena", "seher", "esma", "veysel" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);
            Console.WriteLine(names[5]);
            names.Add("herbin");
            Console.WriteLine(names[6]);
            Console.WriteLine(names[0]); //test to first index
            //names.Add("anan");
        }
    }
}
