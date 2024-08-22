namespace _05.Orders
{
    internal class Program
    {
        static void Main()
        {
            
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            void CalculatePrice(string product, int quantity)
            {
                double totalPrice = 0;

                if (product == "coffee")
                {
                    double price = 1.50;
                    totalPrice = price * quantity;

                }
                else if (product == "water")
                {
                    double price = 1.00;
                    totalPrice = price * quantity;

                }
                else if (product == "coke")
                {
                    double price = 1.40;
                    totalPrice = price * quantity;

                }
                else if (product == "snacks")
                {
                    double price = 2.00;
                    totalPrice = price * quantity;

                }

                Console.WriteLine($"{totalPrice:f2}");

                
            }

            CalculatePrice(product, quantity);
        }
    }
}