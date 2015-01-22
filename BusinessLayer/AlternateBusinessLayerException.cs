using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace BusinessLayer
{
    /// <summary>
    /// Base class for a family of error-specific exceptions
    /// </summary>
    public abstract class AlternateBusinessLayerException : Exception
    {
        protected AlternateBusinessLayerException(string message)
            : base(message)
        {
        }

        protected AlternateBusinessLayerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
