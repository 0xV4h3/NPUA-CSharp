using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public sealed class ProductCode : IEquatable<ProductCode>
    {
        public string Sku { get; }
        public string? Country { get; }

        public ProductCode(string sku, string? country = null)
        {
            Sku = sku ?? throw new ArgumentNullException(nameof(sku));
            Country = country;
        }

        public bool Equals(ProductCode? other) =>
            other is not null &&
            Sku == other.Sku &&
            Country == other.Country;

        public override bool Equals(object? obj) => Equals(obj as ProductCode);

        public override int GetHashCode() => HashCode.Combine(Sku, Country);

        public override string ToString() => Country is null ? Sku : $"{Sku}-{Country}";
    }
}
