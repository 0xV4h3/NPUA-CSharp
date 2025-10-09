namespace Laborator8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("== File Reader Demo ==");
            FileReaderDemo.Run();

            Console.WriteLine("\n== Custom Exception Demo ==");
            CustomExceptionDemo.Run();

            Console.WriteLine("\n== Inner Exception Demo ==");
            InnerExceptionDemo.Run();

            Console.WriteLine("\n== Exception Filter Demo ==");
            ExceptionFilterDemo.Run();
        }
    }
}
