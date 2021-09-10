using System;
namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        //ctor ile oluşturuldu
        //constructor: newlediğimiz anda çalışan blok
        public MyList()
        {
            items = new T[0];    
        }
        public void Add(T item)
        {
            //yeni bi dizi elemanı ekledikçe eski elemanlar silinir
            //bu elemanların silinmemesi içim tempArray dizisinde barındırıyoruz
            //
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //eski elemanları saklaması için kullandığımız değişkenimizden, eski elemanlarımızı çağırıyoruz
            for (int i = 0; i < tempArray.Length; i++) //tempArraydeki tüm elemanları tek tek  items'a alıyoruz
            {

                items[i] = tempArray[i]; //transfer tamamlandı ve artık boş bir elemanımız daha var (yeni dizi elemanı, diğer elemanlar silinmeden eklenmiş oldu)
            }
            items[items.Length - 1] = item; // add fonksiyonun parametresi olan item'ı items dizisinin son elemanı olarak atadık.


            //yani böyle hayvan gibi kod yazmak yerine List yapısını kullanalım.
        }
        
    }
}
