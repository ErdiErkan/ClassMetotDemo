using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customers customer)
        {
            Console.WriteLine("Tebrikler Müşteri Ad Ekleme İşmeniniz Gerçekleşti : " + customer.Ad);
        }

        public void Sil(Customers customer)
        {
            Console.WriteLine("Tebrikler Müşteri TcNo Silme İşmeniniz Gerçekleşti : " + customer.TcNo);
        }
        
        public void GetAll(Customers [] customer)
        {
            foreach (var custo in customer)
            {
                Console.WriteLine(custo.Ad + " " + custo.Soyad + " " + custo.TcNo + " " + custo.DogumYeri);
            }
        }
    }
}
