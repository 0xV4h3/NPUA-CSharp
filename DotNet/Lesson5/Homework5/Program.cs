using System.Threading.Tasks;

namespace Homework5
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await GetUserOrdersDemo.Run();
            await DelayDemo.Run();
            await ResultVsAwaitDemo.Run();
        }
    }
}