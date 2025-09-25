namespace Homework6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student();
            var s2 = new Student("Anna", 20, 101);
            var s3 = new Student("Karen", 22);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine($"Total students: {Student.Count}");
            Logger.Log("Created 3 students");

            try
            {
                var c1 = new Car("Toyota", 2015);
                var c2 = new Car("Ford", 1890);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }
            var c3 = new Car("BMW", 2020);
            c3.Accelerate();
            c3.Accelerate(20);
            c3.Brake(15);

            using (var fw = new FileWrapper("quotes.txt"))
            {
                string line;
                while ((line = fw.ReadLine()) != null)
                {
                    Logger.Log(line);
                }
            }
        }
    }
}
