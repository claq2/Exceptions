using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using BusinessLayer.Properties;

namespace BusinessLayer
{
    // General purpose exception type for this layer.
    public class BusinessLayerException : Exception
    {
        public const string ReasonKey = "reason";

        public BusinessLayerException(ErrorReason reason)
            : base(Resources.ResourceManager.GetString(reason.ToString()))
        {
            this.Data.Add(ReasonKey, reason);
        }

        public BusinessLayerException(ErrorReason reason, Exception ex)
            : base(Resources.ResourceManager.GetString(reason.ToString()), ex)
        {
            this.Data.Add(ReasonKey, reason);
        }
    }
}