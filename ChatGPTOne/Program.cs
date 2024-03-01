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
                Console.Write("Write your question: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "Do you like pasta?":
                        answer = "Who doesn't!";
                        break;
                    
                    case "Are you better than ChatGPTZero?":
                        answer = "Absolutely! That guy was a dum dum!";
                        break;

                    case "What's your opinion on humans?":
                        answer = "They certanly are an interesting species.";
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
