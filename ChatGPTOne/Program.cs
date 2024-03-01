using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main()
        {
            string input,answer;

            do
            {
                Console.Write("Escreva a sua pergunta: ");
                input = Console.ReadLine();

                switch (input)
                {
                    default:
                        answer = "Sorry, I could not interpret that question!";
                        break;
                }

                Console.WriteLine($"ChatGPTOne: {answer}");

            } while(input != "EXIT");

        }
    }
}
