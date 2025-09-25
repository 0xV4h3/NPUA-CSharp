using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework5
{
    public class Email
    {
        private readonly string address;

        public Email(string? address)
        {
            if (address == null)
                throw new ArgumentNullException(nameof(address));
            this.address = Normalize(address);
        }

        private string Normalize(string input)
        {
            return input.Trim().ToLowerInvariant();
        }

        public bool IsValid()
        {
            return Regex.IsMatch(address, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public override string ToString()
        {
            return address;
        }
    }
}
