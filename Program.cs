using System;

namespace Labas_3
{
    static class Program
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("To run a part of MyFrac, enter 1.");
                Console.WriteLine("To perform the second block, enter 2.");
                Console.WriteLine("To end the program, enter 0.");
                Console.WriteLine("------------------------------------------");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Block1.DoBlock();
                        break;
                    case 2:
                        Block2.DoBlock();
                        break;
                    case 0:
                        Console.WriteLine("Ending.");
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
            } while (choice != 0);
        }
    }
}