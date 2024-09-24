using System.Diagnostics;

namespace AlişverişV1;

class Program
{
    static void Main(string[] args)
    {
        string[] ürünler = { "Erik", "Karpuz", "Vişne", "Elma", "Armut" };
        int[] fiyatlar = { 10, 5, 3, 1, 6 };
        int topFiyat = 0;
        string input;
        string klavye = "";

        do
        {
            System.Console.WriteLine("---MARKETTEKİ ÜRÜNLER---");

            for (int i = 0; i < ürünler.Length; i++)
            {
                System.Console.WriteLine($"{i + 1}.Ürün => {ürünler[i]} Fiyatı = {fiyatlar[i]}TL");
            }


            System.Console.Write("Almak istediğiniz ürünün numarasını giriniz Toplamını görmek için 'T' basınız! =>");
            input = Console.ReadLine().ToUpper();

            if (input != "T")
            {
                int ürünNum;
                bool kontrol = int.TryParse(input, out ürünNum);
                if (kontrol && ürünNum >= 1 && ürünNum <= ürünler.Length)
                {
                    topFiyat += fiyatlar[ürünNum - 1];
                    Console.WriteLine($"{ürünler[ürünNum - 1]} sepete eklendi. Fiyatı: {fiyatlar[ürünNum - 1]} TL");
                }
            }
            else
            {
                System.Console.WriteLine($"Ürünlerin Toplamı = {topFiyat}TL");
                System.Console.WriteLine("Alışverişe devam etmek istemiyorsanız 'D' tuşuna basınız");
                klavye = Console.ReadLine().ToUpper();
            }

        } while (klavye != "D");
        {
            System.Console.WriteLine("Bizi Terih Ettiğiniz için Teşekkür Ederiz!! :)");
        }
    }
}
