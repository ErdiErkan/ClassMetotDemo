using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Ad = "Mert";
            customer1.Soyad = "Enkan";
            customer1.TcNo = "1111111111";
            customer1.DogumYeri = "Bakırköy";

            Customers customer2 = new Customers();
            customer2.Ad = "Sinan";
            customer2.Soyad = "Bozok";
            customer2.TcNo = "2222222222";
            customer2.DogumYeri = "Adana";

            Customers customer3 = new Customers();
            customer3.Ad = "Pelin";
            customer3.Soyad = "Sertac";
            customer3.TcNo = "3333333333";
            customer3.DogumYeri = "Kars";

            Customers customer4 = new Customers();
            customer4.Ad = "Fahri";
            customer4.Soyad = "Gunok";
            customer4.TcNo = "4444444444";
            customer4.DogumYeri = "Kastamonu";

            Customers[] customers = new Customers[]
            {
                customer1,customer2,customer3,customer4
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer1);
            customerManager.Sil(customer3);

            Console.WriteLine("-----------------------------------------");

            foreach (var custom in customers)
            {
                Console.WriteLine(custom.Ad);
            }
            Console.WriteLine("Müşteriler Başarılı Şekilde Sıralandı");
        }
    }
}
