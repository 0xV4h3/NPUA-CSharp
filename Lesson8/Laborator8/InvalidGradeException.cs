using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator8
{
    public class InvalidGradeException : Exception
    {
        public InvalidGradeException(string message) : base(message) { }
    }
}
