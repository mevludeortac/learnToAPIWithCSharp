using System;
namespace OOPThree
{
    
        //bu classımız base classımız olduğu için şablon görevi görür
        //şablon görevi gördüğünü belirtmek için de INTERFACE kullanıyoruz
        //interfaceleri birbirinin aletrnatifi olan ama kod içerikleri farklı olan durumlar için kullanırız

        //interface olduğunu anlamak için başına "I" harfi koyuyoruz
        public interface ICreditManager
        {
             void Calculate();
        }
    //LOGLAMA: kim ne zaman hangi operasyonu çağırdı
    //sistemde olan hareketlerin dökümü
    //logları bi dosyada tutabiliriz
    //logları veritabanında tutabiliriz
    //logları sms olarak da atabiliriz
    //logları maille yollayabiliriz
}
