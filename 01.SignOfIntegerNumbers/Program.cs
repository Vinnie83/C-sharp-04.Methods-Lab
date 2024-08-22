namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            void CheckNumber()
            {
                if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive. ");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative. ");
                }
                if (number == 0)
                {
                    Console.WriteLine($"The number {number} is zero. ");
                }
            }

            CheckNumber();

        }
    }
}