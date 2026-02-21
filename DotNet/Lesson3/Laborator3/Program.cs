namespace Laborator3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //FileProcessor.Run(args);
            var ordersPath = Path.Combine(Environment.CurrentDirectory, "orders.txt");
            using (var processor = new OrdersProcessor(ordersPath))
            {
                Console.WriteLine("Create new order");
                Console.Write("Enter order total: ");
                var input = Console.ReadLine();
                decimal total = decimal.TryParse(input, out decimal t) ? t : 0;
                processor.CreateOrder(total);

                var sum = processor.GetTotalSum();
                Console.WriteLine($"Total sum of orders: {sum}");

                processor.SaveOrders();
                Console.WriteLine("Orders saved to file");
            }
            Console.WriteLine("Resources released");
        }
    }
}
