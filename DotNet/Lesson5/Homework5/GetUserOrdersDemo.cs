using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework5
{
    public class GetUserOrdersDemo
    {
        public static async Task Run()
        {
            Console.WriteLine("--- Async pipeline demo ---");

            User user = await GetUserAsync();
            List<Order> orders = await GetOrdersAsync(user);

            Console.WriteLine($"User: {user.Name}");
            Console.WriteLine("Orders:");
            foreach (var order in orders)
            {
                Console.WriteLine($"Order #{order.Id}: {order.Amount}");
            }
            Console.WriteLine();
        }

        public static async Task<User> GetUserAsync()
        {
            await Task.Delay(500);
            return new User { Name = "D.Trump" };
        }

        public static async Task<List<Order>> GetOrdersAsync(User user)
        {
            await Task.Delay(500);
            return new List<Order>
            {
                new Order { Id = 1, Amount = 100.0m },
                new Order { Id = 2, Amount = 220.0m },
            };
        }

        public class User
        {
            public string Name { get; set; }
        }

        public class Order
        {
            public int Id { get; set; }
            public decimal Amount { get; set; }
        }
    }
}