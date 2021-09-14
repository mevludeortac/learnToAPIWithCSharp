using System;
namespace OOP3
{
    //bu classımız base classımız olduğu için şablon görevi görür
    //şablon görevi gördüğünü belirtmek için de INTERFACE kullanıyoruz


    //interface olduğunu anlamak için başına "I" harfi koyuyoruz
    interface ICreditManager
    {
        void Calculate();
    }
}
