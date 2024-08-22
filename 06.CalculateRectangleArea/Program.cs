namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            static double GetRectangleArea(double width, double height)
            {
                return width * height;
            }

            double area = GetRectangleArea(width, height);  
            Console.WriteLine(area);
           
        }
    }
}