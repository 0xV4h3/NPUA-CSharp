using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class LibraryBook
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }

        public LibraryBook(string title, string author)
            : this(title, author, DateTime.Now.Year) { }

        public LibraryBook(string title)
            : this(title, "Unknown", DateTime.Now.Year) { }

        public LibraryBook(string title, string author, int year)
        {
            Title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title.Trim();
            Author = string.IsNullOrWhiteSpace(author) ? "Unknown" : author.Trim();
            var currentYear = DateTime.Now.Year;
            if (year < 1450 || year > currentYear)
                Year = currentYear;
            else
                Year = year;
        }

        public override string ToString()
        {
            return $"\"{Title}\" by {Author} ({Year})";
        }
    }
}
