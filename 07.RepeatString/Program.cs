namespace _07.RepeatString
{
    internal class Program
    {
        static void Main()
        {
            
            string letters = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            //void RepeatString(string letters, int n)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(letters);
            //    }
            //}

            //RepeatString(letters, n);

            RepeatString(letters, n);

        }

        private static string RepeatString(string letters, int n)
        {
            string result = "";

            for (int i = 0; i < n;i++)
            {
                Console.Write(result = letters);
            }

            return result;
        }
    }
}