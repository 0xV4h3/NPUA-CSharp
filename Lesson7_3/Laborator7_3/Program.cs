namespace Laborator7_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("== Value equality & hashing ==");
            ProductEqualityDemo.Run();

            Console.WriteLine("\n== Money ToString formats ==");
            MoneyToStringDemo.Run();

            Console.WriteLine("\n== Dispose pattern + SafeHandle ==");
            DisposeDemo.Run();

            Console.WriteLine("\n== Shallow vs Deep Clone ==");
            CloneDemo.Run();
        }
    }
}
