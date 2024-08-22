namespace _08.MathPower
{
    internal class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            static double GetPower(double number, int power)
            {
                double result = 1d;

                for (int i = 0; i < power; i++)
                {
                    result *= number;
                }

                return result;
            }

            Console.WriteLine(GetPower(number, power));
        }
    }
}