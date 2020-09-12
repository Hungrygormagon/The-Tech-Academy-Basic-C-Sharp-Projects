using System;
using System.Collections.Generic;
using System.Text;

namespace UserAge
{
    class NegAgeException : Exception
    {
        public NegAgeException()
    : base() { }
        public NegAgeException(string message)
            : base(message) { }
    }
}
