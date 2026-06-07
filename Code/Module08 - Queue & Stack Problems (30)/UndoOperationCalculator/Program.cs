using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoOperationCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //declear stack to store previous results for undo operation
            Stack<decimal> stack = new Stack<decimal>();
            decimal currentResult = 0;
            stack.Push(currentResult); //initial result
            Console.WriteLine($"Current Result: {currentResult}");
            Console.WriteLine();

            Console.WriteLine("1- Add 10");
            Console.WriteLine("2- Subtract 10");
            Console.WriteLine("3- Multiply by 2");
            Console.WriteLine("4- Divide by 2");
            Console.WriteLine("5- Undo");
            Console.WriteLine("6- Exit");

            StartCalculator(stack);

            Console.WriteLine("\nPress Any Key...");
            Console.ReadKey();
        }

        static void StartCalculator(Stack<decimal> stack)
        {
            bool running = true;
            int choice;
            decimal currentResult = 0;
            while (running)
            {
                Console.Write("\nChoose: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        currentResult += 10;
                        stack.Push(currentResult);
                        Console.WriteLine($"Current Result: {currentResult}");
                        break;

                    case 2:
                        currentResult -= 10;
                        stack.Push(currentResult);
                        Console.WriteLine($"Current Result: {currentResult}");
                        break;

                    case 3:
                        currentResult *= 2;
                        stack.Push(currentResult);
                        Console.WriteLine($"Current Result: {currentResult}");
                        break;

                    case 4:
                        currentResult /= 2;
                        stack.Push(currentResult);
                        Console.WriteLine($"Current Result: {currentResult}");
                        break;

                    case 5:
                        if (stack.Count > 0)
                        {
                            currentResult = stack.Pop();
                            Console.WriteLine($"after Undo Current Result: {currentResult}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No operations to undo.");
                        }
                        break;

                    case 6:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }

    }
}
