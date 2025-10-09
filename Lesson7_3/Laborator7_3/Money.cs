using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public sealed class Money : IFormattable
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        }

        public override string ToString() => $"{Amount:0.00} {Currency}";

        public string ToString(string? format, IFormatProvider? provider)
        {
            format = format?.ToUpperInvariant();
            var nfi = (provider as NumberFormatInfo) ?? CultureInfo.InvariantCulture.NumberFormat;
            return format switch
            {
                "F" => $"{Amount.ToString("N2", nfi)} {Currency}",
                "S" => $"{Currency} {Amount.ToString("0.00", nfi)}",
                _ => ToString()
            };
        }
    }
}
