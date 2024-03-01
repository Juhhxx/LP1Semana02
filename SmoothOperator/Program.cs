using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insira um número inteiro não negativo: ");
            string num = Console.ReadLine();

            byte n = byte.Parse(num);

            Console.WriteLine(--n);
            Console.WriteLine(++n);
    
        }
    }
}
