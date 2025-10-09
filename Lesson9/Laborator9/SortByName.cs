using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator9
{
    public class SortByName : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
            => string.Compare(x?.Name, y?.Name);
    }
}
