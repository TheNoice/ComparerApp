using System;
using System.Collections.Generic;
using System.Text;

namespace ComparerApp.Library.Utils
{
    public class ComparerValidityException : Exception
    {
        public ComparerValidityException(string message) : base(message)
        {
        }
    }
}
