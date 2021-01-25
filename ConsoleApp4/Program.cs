//Wisselkoers 1.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal wisselkoers = 1.21m;

            Console.WriteLine("geef euro waarde in ");
            decimal geld = decimal.Parse( Console.ReadLine());
            decimal nieuwgeld = geld * wisselkoers ;
            Console.WriteLine($"u {geld}€ is {nieuwgeld} dolar ");
            Console.ReadLine();
        }
    }
}
