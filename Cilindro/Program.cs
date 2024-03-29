﻿using System;

namespace Cilindro
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insira a altura do cilindro: ");
            string alt = Console.ReadLine();
            int a = int.Parse(alt);

            Console.Write("Insira o raio da base do cilindro: ");
            string raio = Console.ReadLine();
            int r = int.Parse(raio);

            float Vol = MathF.PI * MathF.Pow(r,2) * a;
            float Spr = 2 * MathF.PI * r * (r + a);

            Console.WriteLine($"O volume do cilindro é {Vol}");
            Console.WriteLine($"A área da superfície do cilindro é {Spr}");
        }
    }
}
