using System;

namespace ScontoNegozioRivale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("totale speso?");
            double totale = double.Parse(Console.ReadLine());
            double sconto;
            double sconto1;
            double sconto2;
            double scontato;
            double spesainpiu;
            if (totale <= 300)
            {
                sconto = totale / 100 * 10;
                scontato = totale - sconto;
                Console.WriteLine($"l'importo da pagare è {scontato}");
            }
            else if (totale > 300)
            {
                sconto1 = 300 / 100 * 10;
                spesainpiu = totale - 300;
                sconto2 = spesainpiu / 100 * 20;
                sconto = sconto1 + sconto2;
                scontato = totale - sconto;
                Console.WriteLine($"l'importo da pagare è {scontato}");
            }
            Console.ReadLine();
        }
        
    }
}
