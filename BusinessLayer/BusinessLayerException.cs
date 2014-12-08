using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BusinessLayer
{
    // General purpose exception type for this layer. The alternative is an exception type for each error.
    public class BusinessLayerException : Exception
    {
        public const string ReasonKey = "reason";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reason"></param>
        public BusinessLayerException(ErrorReason reason)
        {
            this.Data.Add(ReasonKey, reason);
        }

        public BusinessLayerException(string message, ErrorReason reason)
            : base(message)
        {
            this.Data.Add(ReasonKey, reason);
        }

        public BusinessLayerException(string message, Exception innerException, ErrorReason reason)
            : base(message, innerException)
        {
            this.Data.Add(ReasonKey, reason);
        }

        protected BusinessLayerException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            
        }
    }
}