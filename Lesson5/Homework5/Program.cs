namespace Homework5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(1, 2);
            var p3 = new Point(2, 3);
            Console.WriteLine($"{p1} == {p2}: {p1.Equals(p2)}");
            Console.WriteLine($"{p1} == {p3}: {p1.Equals(p3)}");
            Console.WriteLine($"HashCodes: {p1.GetHashCode()}, {p2.GetHashCode()}");

            var e1 = new Email(" GitHub@gmail.com ");
            Console.WriteLine($"Normalized: {e1}");
            Console.WriteLine($"IsValid: {e1.IsValid()}");

            var e2 = new Email("invalid-email");
            Console.WriteLine($"Normalized: {e2}");
            Console.WriteLine($"IsValid: {e2.IsValid()}");

            var b1 = new LibraryBook("War and Peace", "Leo Tolstoy", 1869);
            var b2 = new LibraryBook("Crime and Punishment", "Fyodor Dostoevsky");
            var b3 = new LibraryBook("Unknown Book");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);

            var settings = new AppSettings(environment: "Prod", version: "1.2.0");
            Console.WriteLine(settings);
        }
    }
}
