namespace Laborator9
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("== Interface Basic Demo ==");
            InterfaceBasicDemo.Run();

            Console.WriteLine("\n== Explicit Interface Demo ==");
            ExplicitInterfaceDemo.Run();

            Console.WriteLine("\n== Prime Iterator Demo ==");
            PrimeDemo.Run();

            Console.WriteLine("\n== Custom Sort Demo ==");
            CustomSortDemo.Run();
        }
    }
}
