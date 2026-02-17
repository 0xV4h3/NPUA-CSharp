namespace Practical1
{
    public class Program
    {
        public void Main(string[] args)
        {
            SQLConnectionDemo.Run();
            SQLCommandDemo.Run();
            SQLTransactionDemo.Run();
            SQLConnectionPoolDemo.Run();
        }
    }
}
