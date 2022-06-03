using System;
using System.Collections.Generic;
using System.Text;

namespace Labas_3
{ 
    class Block1
    {
        public static void DoBlock()
        {
            int ch;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Enter 1, to go to action with one fraction.");
                Console.WriteLine("Enter 2, to go to action with two fractions.");
                Console.WriteLine("Enter 3, to go to CalcSum.");
                Console.WriteLine("Enter 0, to go to the blocks` selection.");
                Console.WriteLine("----------------------------------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        FirstStep();
                        break;
                    case 2:
                        SecondStep();
                        break;
                    case 3:
                        ThirdStep();
                        break;
                    case 0:
                        Console.WriteLine("Ending.");
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
            } while (ch != 0);
        }
        static long AlgorithmOfEuclid(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        struct MyFrac
        {
            public long nom, denom;

            public MyFrac(long nom_, long denom_)
            {
                nom = nom_;
                denom = denom_;
                if (denom < 0)
                {
                    nom *= -1;
                    denom = Math.Abs(denom);
                }
                long a = AlgorithmOfEuclid(Math.Abs(nom), denom);
                nom /= a;
                denom /= a;
            }

            public override string ToString()
            {
                return $"{nom}/{denom}";
            }
        }
        static void FirstStep()
        {
            Console.Clear();
            Console.WriteLine("Enter the numerator value.");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator value.");
            long d = long.Parse(Console.ReadLine());
            MyFrac f = new MyFrac(n, d);
            Console.WriteLine($"The resulting fraction: {f}");
            Console.WriteLine($"Fraction with selected whole part: {ToStringWithIntegerPart(f)}");
            Console.WriteLine($"The actual value of the fraction: {DoubleValue(f)}");
            Console.WriteLine("Press Enter to go to the main menu.");
            Console.ReadKey();
        }
        static void SecondStep()
        {
            MyFrac f1 = new MyFrac();
            MyFrac f2 = new MyFrac();
            int choice;
            int ch;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("If you are using this action for the first time, or want to write new fractions, enter 1");
                Console.WriteLine("If you want to continue with the same fractions, enter 2");
                Console.WriteLine("Enter 0 to go to the main menu.");
                Console.WriteLine("--------------------------------------------------------------------------------");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter the value of the numerator of the first fraction.");
                        long n1 = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the denominator of the first fraction.");
                        long d1 = long.Parse(Console.ReadLine());
                        f1 = new MyFrac(n1, d1);
                        Console.WriteLine("Enter the value of the numerator of the second fraction.");
                        long n2 = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the denominator of the second fraction.");
                        long d2 = long.Parse(Console.ReadLine());
                        f2 = new MyFrac(n2, d2);
                        Console.WriteLine("Press Enter to go to the action selection menu.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Enter 1 to execute Plus.");
                        Console.WriteLine("Enter 2 to execute Minus.");
                        Console.WriteLine("Enter 3 to execute Multiply.");
                        Console.WriteLine("Enter 4 to execute Divide.");
                        Console.WriteLine("Enter 0 to go to the main menu.");
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Enter 1 to execute Plus.");
                        Console.WriteLine("Enter 2 to execute Minus.");
                        Console.WriteLine("Enter 3 to execute Multiply.");
                        Console.WriteLine("Enter 4 to execute Divide.");
                        Console.WriteLine("Enter 0 to go to the main menu.");
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
                if (ch == 0)
                {
                    Console.WriteLine("Let's go back.");
                    break;
                }
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Your fractions: {f1}, {f2}");
                        MyFrac sum = Plus(f1, f2);
                        Console.WriteLine($"The sum of two fractions: {sum}");
                        Console.WriteLine("Press Enter to go to the beginning of this section.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Your fractions: {f1}, {f2}");
                        MyFrac min = Minus(f1, f2);
                        Console.WriteLine($"The difference of two fractions: {min}");
                        Console.WriteLine("Press Enter to go to the beginning of this section.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Your fractions: {f1}, {f2}");
                        MyFrac mul = Multiply(f1, f2);
                        Console.WriteLine($"The product of two fractions: {mul}");
                        Console.WriteLine("Press Enter to go to the beginning of this section.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"Your fractions: {f1}, {f2}");
                        MyFrac div = Divide(f1, f2);
                        Console.WriteLine($"The result of dividing two fractions: {div}");
                        Console.WriteLine("Press Enter to go to the beginning of this section.");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Let's go back.");
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
            } while (choice != 0);
        }

        static void ThirdStep()
        {
            Console.Clear();
            Console.WriteLine("Enter a natural number n");
            int n = int.Parse(Console.ReadLine());
            int choice;
            MyFrac result;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Enter 1 if you want to execute CalcSum1");
                Console.WriteLine("Enter 2 if you want to execute CalcSum2");
                Console.WriteLine("Enter 0 to go to the main menu.");
                Console.WriteLine("-----------------------------------------");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        result = CalcSum1(n);
                        Console.WriteLine($"The result of CalcSum1 {result}");
                        Console.WriteLine("Press Enter to go to the action selection menu.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        result = CalcSum2(n);
                        Console.WriteLine($"The result of CalcSum2 {result}");
                        Console.WriteLine("Press Enter to go to the action selection menu.");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Let's go back.");
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
            } while (choice != 0);
        }
        static string ToStringWithIntegerPart(MyFrac f)
        {
            bool negativeNum = false;
            string result;
            if (f.nom < 0)
            {
                f.nom = Math.Abs(f.nom);
                negativeNum = true;
            }
                var remainder = (long)(f.nom % f.denom);
                var num = (long)(f.nom / f.denom);
                result = negativeNum == true ? $"-({num}+{remainder}/{f.denom})" : $"({num}+{remainder}/{f.denom})";          
            return result;
        }
        static double DoubleValue(MyFrac f)
        {
            double nom = f.nom;
            double denom = f.denom;
            double result = nom / denom;
            return result;
        }
        static MyFrac Plus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom + f1.denom * f2.nom, f1.denom * f2.denom);
        }
        static MyFrac Minus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom - f1.denom * f2.nom, f1.denom * f2.denom);
        }
        static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            MyFrac result = new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
            return result;
        }
        static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            MyFrac result = new MyFrac(f1.nom * f2.denom, f2.nom * f1.denom);
            return result;
        }
        static MyFrac CalcSum1(int num)
        {
            MyFrac result = new MyFrac(0, 1);
            for (int n = 1; n <= num; n++)
            {
                result = Plus(result, new MyFrac(1, n * (n + 1)));
            }
            return result;
        }
        static MyFrac CalcSum2(int num)
        {
            MyFrac result = new MyFrac(1, 1);
            for (int n = 2; n <= num; n++)
            {
                MyFrac minus = Minus(new MyFrac(1, 1), new MyFrac(1, n * n));
                result = Multiply(minus, result);
            }
            return result;
        }
    }
}
