using System;
using System.Net;

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
                    case "Do you like pasta?":
                        answer = "Who dosen't!";
                        break;
                        
                    case "EXIT":
                        continue;

                    default:
                        answer = "Sorry, I could not interpret that question!";
                        break;
                }

                Console.WriteLine($"ChatGPTOne: {answer}");

            } while(input != "EXIT");

        }
    }
}
