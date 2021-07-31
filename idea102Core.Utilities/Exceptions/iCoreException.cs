using System;
using System.Collections.Generic;
using System.Text;

namespace idea102Core.Utilities.Exceptions
{
    public class iCoreException : Exception
    {
        public iCoreException()
        {
        }

        public iCoreException(string message)
            : base(message)
        {
        }

        public iCoreException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
