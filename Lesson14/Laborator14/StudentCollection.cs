using System;
using System.Collections;
using System.Collections.Generic;

namespace Laborator14
{
    public class StudentCollection : IEnumerable<Student>
    {
        private readonly List<Student> _items;

        public StudentCollection() => _items = new List<Student>();
        public StudentCollection(IEnumerable<Student> source) => _items = new List<Student>(source);

        // Indexer
        public Student this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public int Count => _items.Count;

        public void Add(Student s) => _items.Add(s);

        public static StudentCollection operator +(StudentCollection a, StudentCollection b)
        {
            if (a is null) throw new ArgumentNullException(nameof(a));
            if (b is null) throw new ArgumentNullException(nameof(b));
            return new StudentCollection(a._items).ConcatInPlace(b._items);
        }

        private StudentCollection ConcatInPlace(IEnumerable<Student> other)
        {
            _items.AddRange(other);
            return this;
        }

        public static implicit operator List<Student>(StudentCollection c)
            => c is null ? null! : new List<Student>(c._items);

        public IEnumerator<Student> GetEnumerator() => _items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}