namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main()
        {
           int number = int.Parse(Console.ReadLine());

           static void GetMultipleOfEvenAndOdds(int number)
           {
                int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
                Console.WriteLine(result);    

           }

           static int GetSumOfEvenDigits(int number)
           {
       
                int currentNumber = Math.Abs(number);

                int sumEven = 0;

                while (currentNumber > 0)
                {
                    int cuurrentDigit = currentNumber % 10;

                    if (cuurrentDigit % 2 == 0)
                    {
                        sumEven += cuurrentDigit;
                    }

                    currentNumber /= 10;
                }

                return sumEven;

           }


           static int GetSumOfOddDigits(int number)
           {
                int currentNumber = Math.Abs(number);

                int sumOdd = 0;

                while (currentNumber > 0)
                {
                    int cuurrentDigit = currentNumber % 10;

                    if (cuurrentDigit % 2 != 0)
                    {
                        sumOdd += cuurrentDigit;
                    }

                    currentNumber /= 10;
                }

                return sumOdd;
            }

            GetMultipleOfEvenAndOdds(number);

        }
    }
}