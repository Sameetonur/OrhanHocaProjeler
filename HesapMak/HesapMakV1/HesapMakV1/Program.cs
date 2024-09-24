namespace HesapMakV1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Kaç adet sayı toplanacak belirtiniz => ");
        int input = int.Parse(Console.ReadLine());


        int toplam = 0;
        int ort = 0;


        for (int i = 0; i < input; i++)
        {
            System.Console.Write($"{i + 1}.Sayı=> ");


            int input1 = int.Parse(Console.ReadLine());
            toplam += input1;
            ort = toplam / input;
        }


        System.Console.WriteLine($"girdiğiniz sayıların toplamı: {toplam}\nGirilen sayıların ortalaması: {ort}");
    }
}
