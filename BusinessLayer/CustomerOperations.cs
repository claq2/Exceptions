using BusinessLayer.Properties;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerOperations
    {
        public void SaveCustomer(CustomerDto customer)
        {
            try
            {
                // One or the other will fail.
                new SqlOperations().SaveCustomer(customer.ToDataLayerObject());
                new WcfOperations().SaveCustomer(customer.ToDataLayerObject());
            }
            catch (Exception ex)
            {
                // We don't want to report the specific failure so we throw a business exception related to the operation.
                // Send along a culture-specific string and an error code in the Data dictionary.
                // Possible actions are:
                // 1. log ex and then throw new BusinessLayerException without ex as the inner exception
                // 2. wrap ex into the BusinessLayerException
                // It depends on your logging mechanism. Is there a central exception logging system in the next layer up?
                throw new BusinessLayerException(ErrorReason.SaveCustomerError, ex);
                // or
                // throw new SaveCustomerException(ex);
            }
        }
    }
}
