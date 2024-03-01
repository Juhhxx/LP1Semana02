using System;

namespace Cilindro
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insira a altura do cilindro: ");
            string alt = Console.ReadLine();
            int a = int.Parse(alt);

            Console.Write("Insira o raio da abse do cilindro: ");
            string raio = Console.ReadLine();
            int r = int.Parse(raio);
        }
    }
}
