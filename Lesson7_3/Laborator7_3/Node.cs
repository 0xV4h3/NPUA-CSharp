using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }

        public Node Shallow() => (Node)this.MemberwiseClone();

        public Node Deep() => new Node { Value = Value, Next = Next?.Deep() };
    }
}
