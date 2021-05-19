using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string answerStr;
            int answer;

            Console.Write("Enter an integer: ");

            while (1 == 1)
            {
                answerStr = Console.ReadLine();
                if (!int.TryParse(answerStr, out answer) && answerStr != "q" && answerStr != "Q")
                {
                    Console.WriteLine("Invalid input. Enter an integer, or enter 'q' to quit: ");
                    continue;
                }
                else if (answerStr == "q" || answerStr == "Q")
                {
                    return;
                }
                else
                {
                    break;
                }
            }


            while (1 == 1)
            {
                var evenNumber = answer % 2 == 0;
                if (evenNumber)
                {
                    Console.WriteLine($"{answer} is even.");
                }
                else
                {
                    Console.WriteLine($"{answer} is odd.");
                }

                Console.WriteLine("Enter another integer, or enter 'q' to quit.");

                while (1 == 1)
                {
                    answerStr = Console.ReadLine();
                    if (!int.TryParse(answerStr, out answer) && answerStr != "q" && answerStr != "Q")
                    {
                        Console.WriteLine("Invalid input. Enter an integer, or enter 'q' to quit: ");
                        continue;
                    }
                    else if (answerStr == "q" || answerStr == "Q")
                    {
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
