namespace Quiz;

class Program
{
    static void Main()
    {

        string[] sorular = { "Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?", "Türkiyenin En iyi Takımı Kimdir?" };
        string[] cevaplar = { "mavi", "Ankara", "FENERBAHÇE<3" };
        string[] secenekler = { "Kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir", "FENERBAHÇE<3|Fetösaray|8taş" };

        int dogruSayisi = 0;
        int yanlisSayisi = 0;


        for (int i = 0; i < sorular.Length; i++)
        {
            Console.WriteLine(sorular[i]);


            string[] secenekListesi = secenekler[i].Split('|');
            for (int j = 0; j < secenekListesi.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {secenekListesi[j]}");
            }

            Console.Write("Cevabınızı seçin (1, 2, 3 veya 4): ");
            int kullaniciSecimi = int.Parse(Console.ReadLine());


            if (secenekListesi[kullaniciSecimi - 1].ToLower() == cevaplar[i].ToLower())
            {
                dogruSayisi++;
                //Console.WriteLine("Doğru!\n");
            }
            else
            {
                yanlisSayisi++;
                //Console.WriteLine($"Yanlış! Doğru cevap: {cevaplar[i]}\n");
            }
        }


        Console.WriteLine($"Toplam Doğru: {dogruSayisi}, Yanlış: {yanlisSayisi}");
        System.Console.WriteLine("----Cevap Anahtarı----");
        for (int i = 0; i < cevaplar.Length; i++)
        {
            System.Console.WriteLine($"{i + 1}.Soru Cevabı = {cevaplar[i]}");
        }
    }
}



