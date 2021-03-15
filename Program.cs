using System;

namespace MilhasparaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            string medida;
            double milhas, km;

            Console.Beep();
            Console.WriteLine("----------");
            Console.Write("Digite a medida em milhas: ");
            medida = Console.ReadLine ();
            milhas = Convert.ToDouble (medida);
            km = milhas * 1.609;

            Console.Beep();
            Console.WriteLine("----------");
            Console.WriteLine($"A medida em km é: {km}");
        }
    }
}
