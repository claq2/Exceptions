using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BadExceptions
{
    public class CustomerOperationException : Exception
    {
        public enum CustomerOperationError
        {
            SaveCustomrError,
            LoadCustomerError
        }

        public CustomerOperationError Error { get; set; }
    }
}
