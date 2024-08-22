using System.ComponentModel;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main()
        {
            string operation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Add(number1, number2);
                    break;
                case "multiply":
                    Multiply(number1, number2);
                    break;
                case "subtract":
                    Subtract(number1, number2);
                    break;
                case "divide":
                    Divide(number1, number2);
                    break;
            }
                        
        }

        private static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2); 
        }
        private static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }
        private static void Subtract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }
        private static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }

    }
}