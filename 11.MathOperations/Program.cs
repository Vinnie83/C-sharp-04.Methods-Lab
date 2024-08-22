namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operate = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());


            static double CalculateNumbers(int firstNumber, string operate, int secondNumber)
            {
                double result = 0;

                if (operate == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (operate == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else if (operate == "*")
                {
                    result = firstNumber * secondNumber;
                }
                else if (operate == "/")
                {
                    result = firstNumber / secondNumber;
                }

                return result;
            }

            Console.WriteLine(CalculateNumbers(firstNumber, operate, secondNumber));
        }
    }
}