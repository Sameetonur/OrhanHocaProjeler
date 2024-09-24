namespace HesapMakV4;

class Program
{
    static void Main(string[] args)
    {
        string[] ürünler = { "Erik", "Muz", "Yağ",
                             "Süt", "Karpuz", "Avokado",
                             "Üzüm", "Kavun", "Kahve",
                              "Tavuk", "Zeytin", "Vişne" };
        int[] fiyatlar = { 6, 8, 9, 10, 12, 25,
                              15, 26, 32, 8, 6, 40 };

        int[] stock = { 85, 90, 85, 85, 85, 85,
                        85, 85, 85, 85, 85, 85};


        string[] alınanÜrünler = new string[ürünler.Length];

        int index = 0;


        double toplamFiyat = 0;

        Console.WriteLine("Market ürünleri ve fiyatları:");


        for (int i = 0; i < ürünler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {ürünler[i]} - {fiyatlar[i]}TL - Stok Durumu => {stock[i]}");
        }

        while (true)
        {

            Console.Write("Bir ürün seçin (1-12) ve fişinizi almak için  'F' yazınız  => ");
            string input = Console.ReadLine().ToUpper();

            if (input == "F")
            {

                Console.WriteLine("Alınan ürünler:");
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine($" Alınan Ürünler => {alınanÜrünler[i]}");
                }
                Console.WriteLine($"Toplam tutar=> {toplamFiyat} TL");
                int MüşteriParası = 0;
                int paraÜstü = 0;
                System.Console.WriteLine("Vereceğiniz parayi giriniz =>");
                MüşteriParası = int.Parse(Console.ReadLine());
                paraÜstü = Convert.ToInt32(MüşteriParası - toplamFiyat);
                System.Console.WriteLine($"Geri Verilen Para Üstü = {paraÜstü}TL ");
                System.Console.WriteLine("Stok Kontrol Etmek İçin 'S' basınız!");
                string stockgit = Console.ReadLine().ToUpper();
                if (stockgit == "S")
                {
                    System.Console.WriteLine("---STOK DURUM LİSTESİ---");
                    for (int i = 0; i < ürünler.Length; i++)
                    {
                        Console.WriteLine($" {ürünler[i]} - Stok Durumu => {stock[i]}");
                    }
                }

                break;
            }
            else if (int.TryParse(input, out int urunNo) && urunNo >= 1 && urunNo <= 12)
            {
                Console.Write("Kaç adet almak istiyorsunuz? ");
                if (int.TryParse(Console.ReadLine(), out int adet) && adet > 0)
                {

                    alınanÜrünler[index] = ürünler[urunNo - 1];

                    index++;
                    toplamFiyat += adet * fiyatlar[urunNo - 1];

                    stock[urunNo - 1] -= adet;

                    Console.WriteLine($"{adet} adet {ürünler[urunNo - 1]} sepete eklendi. Şu anki toplam: {toplamFiyat} TL");

                }
                else
                {
                    Console.WriteLine("Geçersiz adet, lütfen tekrar deneyin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
            }

        }
    }
}
