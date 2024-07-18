using System;

namespace YolArkadasiTatil
{
    class Program
    {
        static void Main(string[] args)
        {
            string againPlan = string.Empty;
            do
            {
            int bodrum = 4000;
            int marmaris = 3000;
            int cesme = 5000;
            int cost = 0;
            int road = 1500;
            int airline = 4000;
            System.Console.WriteLine("Yol arkadaşım tatil uygulamasına hoş geldiniz");
            System.Console.WriteLine("");
            System.Console.WriteLine($"1 - Bodrum (Paket başlangıç fiyatı {bodrum} TL)\n2 - Marmaris(Paket başlangıç fiyatı {marmaris}  TL)\n3 - Çeşme (Paket başlangıç fiyatı {cesme} TL)");
            System.Console.WriteLine("Lütfen gitmek istediğiniz konumu seçiniz: ");
            string location = Console.ReadLine().ToLower(); // kullanıcan konum bilgisini alıp tüm harfleri küçük harfe çeviriyoruz

            while (location != "bodrum" && location != "marmaris" && location != "çeşme")
            {
                System.Console.WriteLine("Lütfen üç lokasyondan birini seçiniz:");
                System.Console.WriteLine("Lütfen gitmek istediğiniz konumu seçiniz: ");
                location = Console.ReadLine().ToLower(); // kullanıcan konum bilgisini alıp tüm harfleri küçük harfe çeviriyoruz                
            }
            System.Console.WriteLine("");
            System.Console.Write("Kaç kişi tatil yapacaksınız?: ");
            int person = Convert.ToInt32(Console.ReadLine());  // Kullanıcıdan aldığımız kişi bilgisini int değerine dönüştürüyoruz

            System.Console.WriteLine("");

            if (location == "bodrum")
            {
                System.Console.WriteLine("- Lahmacunu ile ünlüdür \n- Kendine ait para birimi vardır");
                cost = bodrum; // önceden tanımladığım değişken  konuma göre eşitleniyor
            }
            else if(location == "marmaris")
            {
                System.Console.WriteLine("- Denizi serindir \n- Özel villalar vardır tatil yapmak için");
                cost = marmaris; // önceden tanımladığım değişken  konuma göre eşitleniyor
            }
            else 
            {
                System.Console.WriteLine("- Denizi tuzludur \n- Momo en iyi mekanıdır ");
                cost = cesme; // önceden tanımladığım değişken  konuma göre eşitleniyor
            }
            
            
            System.Console.WriteLine("");

            System.Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL ) \n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

            System.Console.Write("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz");

            string choosenWay = Console.ReadLine();

            while (choosenWay != "1" && choosenWay != "2")  // Kullanıcı geçerli bir seçim için tekrar tekrar soru suruyoruz
            {
                System.Console.WriteLine("Lütfen geçerli bir yol seçiniz");
                System.Console.WriteLine("Lütfen gitmek istediğiniz yolu seçiniz: ");
                choosenWay = Console.ReadLine();
            }
            if(choosenWay == "1") 
            {
                cost = (cost + road) * person ; // kullanıcıdan aldığım bilgileri matematik işlemleri ile maliyeti hesaplıyoruz
            }
            else cost = (cost + airline) * person ;// kullanıcıdan aldığım bilgileri matematik işlemleri ile maliyeti hesaplıyoruz

            System.Console.WriteLine("Tatilinizin tutarı " + cost + " TL");
            System.Console.WriteLine("");
            System.Console.WriteLine("Tekrar bir tatil planlamak ister misiniz?:\n 1) Hayır \n 2) Evet"); // kullanıcıdan tekrar maliyet hesabı yapmak istediğini soruyoruz.
            againPlan = Console.ReadLine();
            } while (againPlan == "2"); // eğer kullanıcı evet derse yani koşul sağlanırsa tekrar baştan program çalışır
            System.Console.WriteLine("İyi Günler");
        }
    }
}
