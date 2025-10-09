namespace Laborator7_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Partial Class Demo:");
            PartialDemo.Run();

            Console.WriteLine("\nContainment vs Inheritance:");
            ContainmentInheritanceDemo.Run();

            Console.WriteLine("\nNested Class Demo:");
            NestedClassDemo.Run();

            Console.WriteLine("\nCasting + as/is Demo:");
            CastingDemo.Run();

            Console.WriteLine("\nPattern Matching Demo:");
            PatternMatchingDemo.Run();
        }
    }
}
