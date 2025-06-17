using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz ");
            Console.WriteLine("Adınız:  ");
            Console.ReadLine();
            string ad =Console.ReadLine();
            Console.Write("Soyadınız:  ");
            Console.ReadLine();
            string soyad =Console.ReadLine();

            Console.Write("TC NUMARANIZ: ");
            //Console.ReadLine();
            long tc =long.Parse((Console.ReadLine()));

            Console.Write("Telefon numaranız: ");
            //Console.ReadLine();
            long tel =long.Parse((Console.ReadLine()));

            Console.WriteLine("İlk aldığı ürünün fiyatı:   ");
            //Console.ReadLine();
            int product1 =int.Parse(Console.ReadLine());


            Console.WriteLine("İkinci aldığı ürünün fiyatı:   ");
            //Console.ReadLine();
            int product2 =int.Parse(Console.ReadLine());

            Console.WriteLine(tc +"  "+ "TC numaralı " +"    " + ad + "  " + soyad +"  " +"  "+ "isimli müşteri için kayıt oluşturulmuştur" +" "+ tel +"   " + "telefon numarasına bildirim gönderilmiştir" +" " + (product1 + product2) + "  " + "miktarı kadar harcamanın patika puan karşılığı"+ " " + (product1 + product2) / 10);
            

        }
    }

}