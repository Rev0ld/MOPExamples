using System;

namespace Permutation
{
    internal class Program
    {

        static int PermutatuionShowSteps(int a) //outputs how you got result DOESNT RETURN
        {
            int fact = 1;
            while (true)
            {
                Console.Write(a);
                if (a == 1)
                {
                    break;
                }
                Console.Write("*");
                fact *= a;
                a--;
            }
            Console.WriteLine(" = {0}", fact);

            return fact;
            
        }
        static int Permutation(int number) //Outputs just result RETUNRNS
        {
            int fact  = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            
            return fact;
            

        }

        static void permute(string s, string answer) //Shows all posible variations 
        {
            if (s.Length == 0)
            {
                Console.Write(answer + "  ");
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                string left_substr = s.Substring(0, i);
                string right_substr = s.Substring(i + 1);
                string rest = left_substr + right_substr;
                permute(rest, answer + ch);
            }
        }

        static void Main(string[] args)

        {
            Start:
            
            Console.WriteLine("Choose: Var, Comb, Varshow or Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Var":
                    Console.WriteLine("Вариация от: ");
                    Console.Write("Елемента: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write("Клас: ");
                    int k = int.Parse(Console.ReadLine());

                    double variation = Permutation(n) / Permutation(n - k);
                    Console.WriteLine(variation);
                    Console.WriteLine("----------------------------------");
                    goto Start;
                    

                case "Comb":
                    Console.WriteLine("Комбинация от: ");
                    Console.Write("Елемента: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.Write("Клас: ");
                    int r = int.Parse(Console.ReadLine());

                    double combination = Permutation(p) / (Permutation(r) * Permutation(p - r));
                    Console.WriteLine(combination);
                    Console.WriteLine("----------------------------------");
                    goto Start;

                case "Varshow":
                    string s;
                    string answer = "";

                    Console.Write(
                    "Enter the string : ");
                    s = Console.ReadLine();

                    Console.Write(
                    "\nAll possible strings are : ");
                    permute(s, answer);
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------");

                    goto Start;

                case "Exit":

                    goto End;

                default:
                    Console.WriteLine("try again");
                    Console.WriteLine("----------------------------------");
                    goto Start;
            }
        End:
            Console.WriteLine("GoodBye");
            return;

        }
    }
}
