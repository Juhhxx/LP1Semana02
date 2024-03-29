﻿using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main()
        {
            // Exercice Min and Max values

            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            // Exercice Infinity and NaN

            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            // Exercice Overflow and Underflow

            uint ui = uint.MaxValue;

            Console.WriteLine(ui + 1);

            float f1 = float.MaxValue;

            Console.WriteLine(3*f1);
            Console.WriteLine(f1 + 2);

            float f2 = 100_000.0f;
            float f3 = f2 + 0.00002f;

            Console.WriteLine(f2 == f3);


        }
    }
}
