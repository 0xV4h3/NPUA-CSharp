using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator1
{
    public struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
