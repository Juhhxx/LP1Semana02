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

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} : Magic fire!");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} : Eletric Fire!");
                }
                else
                {
                    Console.WriteLine($"{i} : Normal Fire :/");
                }
            }
        }
    }
}
