namespace TasKağıtMakasV1;

class Program
{
    static void Main(string[] args)
    {

        string[] kelimeler = { "Taş", "Kağıt", "Makas" };
        Random rnd = new Random();


        System.Console.WriteLine("---Seçenekleriniz---");
        for (int i = 0; i < kelimeler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {kelimeler[i]}");
        }


        int input;
        while (true)
        {
            Console.Write("Seçiminizi yapın (1-3)=> ");
            if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 3)
            {
                input--;
                break;
            }
            else
            {
                Console.WriteLine("Lütfen 1-3 arasında bir sayı giriniz!!");
            }
        }

        int rndSec = rnd.Next(0, 3);

        Console.WriteLine($"Bilgisayarın seçimi=> {kelimeler[rndSec]}");

        if (input == rndSec)
        {
            Console.WriteLine("Berabere!");
        }
        else if ((input == 0 && rndSec == 2) || (input == 1 && rndSec == 0) || (input == 2 && rndSec == 1))
        {
            Console.WriteLine("Kazandınız!");
        }
        else
        {
            Console.WriteLine("Kaybettiniz!");
        }

    }
}
