using System.Formats.Asn1;

namespace TasKağıtMakasV2;

class Program
{
    static void Main(string[] args)
    {
        string[] kelimeler = { "Taş", "Kağıt", "Makas" };
        Random rnd = new Random();
        int skor = 0;

        Console.WriteLine("---Seçenekleriniz---");
        for (int i = 0; i < kelimeler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {kelimeler[i]}");
        }

        while (true)
        {
            if (skor >= 100)
            {
                System.Console.WriteLine("Maksimum Skora Ulaştınız Tebrik Ederiz!!");
                break;
            }

            Console.Write("Seçiminizi yapın (1-3) veya 'Exit' yazarak çıkış yapabilirsiniz => ");
            string input1 = Console.ReadLine();

            if (input1.ToLower() == "exit")
            {
                Console.WriteLine("Oyundan Çıkış Yaptınız...");
                break;
            }

            if (int.TryParse(input1, out int input) && input >= 1 && input <= 3)
            {
                input--;
                int rndSec = rnd.Next(0, 3);

                Console.WriteLine($"Bilgisayarın seçimi: {kelimeler[rndSec]}");


                if (input == rndSec)
                {
                    Console.WriteLine("Berabere!");
                }
                else if ((input == 0 && rndSec == 2) || (input == 1 && rndSec == 0) || (input == 2 && rndSec == 1))
                {
                    Console.WriteLine("Kazandınız!");
                    skor += 20;
                }
                else
                {
                    Console.WriteLine("Kaybettiniz!");
                }

                Console.WriteLine($"Şu anki skorunuz: {skor}\n");
            }
            else
            {
                Console.WriteLine("Lütfen 1-3 arasında geçerli bir seçim yapınız.");
            }
        }

    }



}
