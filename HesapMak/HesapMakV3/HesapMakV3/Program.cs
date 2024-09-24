namespace HesapMakV3;

class Program
{
    static void Main(string[] args)
    {
        int işlem;
        string klavye;

        do
        {
            int sayac = 1;
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.Write("Hangi işlemi yapacağınızı 1-4 arasında sayı girerek belirtin => ");
            işlem = int.Parse(Console.ReadLine());
            Console.Write("Kaç adet sayı ile işlem yapmak istiyorsunuz => ");
            int adet = int.Parse(Console.ReadLine());

            int[] list = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                System.Console.Write($"{sayac}.sayınız => ");
                list[i] = int.Parse(Console.ReadLine());

                sayac++;
            }

            double sonuc = list[0];

            if (işlem == 1)
            {
                for (int i = 1; i < list.Length; i++)
                {
                    sonuc += list[i];
                }
                System.Console.WriteLine($"Toplama işlemi sonucu => {sonuc}");
            }
            else if (işlem == 2)
            {

                for (int i = 1; i < list.Length; i++)
                {

                    sonuc -= list[i]; // 10 = 10 -5 // -10 = (-10) - (-10)
                                      // 5=5-2 =3;
                }
                System.Console.WriteLine($"Çıkarma işlemi sonucu => {sonuc}");

            }
            else if (işlem == 3)
            {

                for (int i = 1; i < list.Length; i++)
                {
                    sonuc *= list[i]; // 10 = 10 -5 // -10 = (-10) - (-10)
                                      // 5=5-2 =3;
                }
                System.Console.WriteLine($"Çarpma işlemi sonucu => {sonuc}");
            }
            else if (işlem == 4)
            {
                for (int i = 1; i < list.Length; i++)
                {
                    sonuc /= list[i];
                }
                System.Console.WriteLine($"Bölme işlemi sonucu => {(double)sonuc}");
            }
            else
            {
                System.Console.WriteLine("Lütfen 1 - 4 arasında bir sayı giriniz ! :)");

            }

            Console.Write("Başka bir işlem yapmak ister misiniz? (e girerseniz program kapanıcaktır.) => ");
            klavye = Console.ReadLine().ToLower();


        } while (klavye != "e");
        System.Console.WriteLine("Görüşmek üzere");



    }
}

