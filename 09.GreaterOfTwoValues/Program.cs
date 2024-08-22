using System.Runtime.CompilerServices;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main()
        {

            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int bigger = GetMax(a, b);
                Console.WriteLine(bigger);
            }

            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                char bigger = GetMax(a, b);
                Console.WriteLine(bigger);
            }

            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string bigger = GetMax(a, b);
                Console.WriteLine(bigger);
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
    }
}