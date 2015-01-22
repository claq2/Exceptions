using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BadExceptions
{
    public class OrderOperationException : Exception
    {
        public enum OrderOperationError
        {
            SaveOrderError,
            LoadOrderError
        }

        public OrderOperationError Error { get; set; }
    }
}
