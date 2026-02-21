using System.Text.Json;

namespace Laborator3
{
    class OrdersProcessor : IDisposable
    {
        private readonly string _filePath;
        private readonly List<Order> _orders = new List<Order>();
        private FileStream? _stream;

        public OrdersProcessor(string filePath)
        {
            _filePath = filePath;
            _stream = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
        }

        public void CreateOrder(decimal total)
        {
            var order = new Order
            {
                Code = Guid.NewGuid().ToString(),
                Total = total
            };
            _orders.Add(order);
        }

        public decimal GetTotalSum()
        {
            decimal sum = 0;
            foreach (var order in _orders)
            {
                sum += order.Total;
            }
            return sum;
        }

        public void SaveOrders()
        {
            if (_stream == null)
                return;

            _stream.Seek(0, SeekOrigin.End);
            var json = JsonSerializer.Serialize(_orders, new JsonSerializerOptions { WriteIndented = true });
            var bytes = System.Text.Encoding.UTF8.GetBytes(json + Environment.NewLine);
            _stream.Write(bytes, 0, bytes.Length);
            _stream.Flush();
        }

        public void Dispose()
        {
            if (_stream != null)
            {
                _stream.Dispose();
                _stream = null;
            }
        }
    }
}
