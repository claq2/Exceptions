using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using BusinessLayer.Properties;

namespace BusinessLayer
{
    /// <summary>
    /// Represents a failure to save a customer. Sets its own message
    /// </summary>
    public class SaveCustomerException : AlternateBusinessLayerException
    {
        public SaveCustomerException()
            : base(Resources.SaveCustomerError)
        {
        }

        public SaveCustomerException(Exception ex)
            : base(Resources.SaveCustomerError, ex)
        {
        }
    }
}
