using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public class Product
    {
        public string Name { get; set; }
        public Product(string name) => Name = name;
        public override string ToString() => Name;
    }
}
