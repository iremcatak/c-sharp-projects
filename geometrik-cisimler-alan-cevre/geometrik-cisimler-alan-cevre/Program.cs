using System;

namespace geometrik_cisimler_alan_cevre
{
    class Program
    {
        static void Main(string[] args)
        {
            string sekil;
            double kenar1,kenar2,kenar3, r, alan,cevre,yukseklik;
            double pi=3.14;
            Console.WriteLine(" a-kare\n b-dikdörtgen\n c-üçgen\n d-çember\nHesaplamak istediğiniz geometrik şekli seçin: ");
            sekil=Console.ReadLine();
            //Console.Write(sekil);
            if (sekil == "a")           //kare----------------
            {
                Console.WriteLine("Lütfen kenar uzunluğu giriniz:");
                kenar1 =Convert.ToDouble( Console.ReadLine());
                alan = kenar1 * kenar1;
                cevre = kenar1 * 4;
                Console.WriteLine("Alan= " + alan);
                Console.WriteLine("Çevre= " + cevre);
            }
            else if (sekil == "b")      //dikdörtgen-----------
            {
                Console.WriteLine("Lütfen uzun kenarın uzunluğunu giriniz:");
                kenar1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen kısa kenarın uzunluğunu giriniz:");
                kenar2 = Convert.ToDouble(Console.ReadLine());
                alan = kenar1 * kenar2;
                cevre = kenar1 * 2 + kenar2 * 2;
                Console.WriteLine("Alan= " + alan);
                Console.WriteLine("Çevre= " + cevre);
            }
            else if (sekil == "c")      //üçgen-----------------
            {
                Console.WriteLine("Lütfen kenarların uzunluklarını giriniz:");
                Console.WriteLine("Birinci kenar (taban):");
                kenar1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("İkinci kenar:");
                kenar2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Üçüncü kenar:");
                kenar3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen yüksekliği giriniz:");
                yukseklik = Convert.ToDouble(Console.ReadLine());
                alan = (kenar1 * yukseklik)/2;
                cevre = kenar1  + kenar2 +kenar3;
                Console.WriteLine("Alan= " + alan);
                Console.WriteLine("Çevre= " + cevre);
            }
            else if (sekil == "d")      //çember----------------
            {
                Console.WriteLine("Lütfen yarıçapı giriniz:");
                r = Convert.ToDouble(Console.ReadLine());
                alan = pi * r * r;
                cevre = 2 * pi * r;
                Console.WriteLine("Alan= " + alan);
                Console.WriteLine("Çevre= " + cevre);
            }
            
        }
    }
}
