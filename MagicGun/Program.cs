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
            string shot;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    shot = "Magic fire!";
                }
                else if (i % 5 == 0)
                {
                    shot = "Eletric Fire!";
                }
                else
                {
                    shot = "Normal Fire :/";
                }

                Console.WriteLine($"{i} : {shot}");
            }
        }
    }
}
