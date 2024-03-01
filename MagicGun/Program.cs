using System;

namespace MagicGun
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insira um número inteiro: ");
            string num = Console.ReadLine();
            int n = int.Parse(num);

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine('a');
            }
        }
    }
}
