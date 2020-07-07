using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exception
{
    public class UnsupportedRuleException : System.Exception
    {
        public UnsupportedRuleException()
        {
        }

        public UnsupportedRuleException(string message)
            : base(message)
        {
        }

        public UnsupportedRuleException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
