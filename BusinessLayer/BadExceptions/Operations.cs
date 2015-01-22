using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BadExceptions
{
    public class Operations
    {
        public void SaveCustomerAndOrder(CustomerDto customer, OrderDto order)
        {
            try
            {
                // Load the customer, update it and save it
                // Load the order, update it and save it
            }
            catch (CustomerOperationException ex)
            {
                switch (ex.Error)
                {
                    case CustomerOperationException.CustomerOperationError.SaveCustomrError:
                        throw new BusinessLayerException(ErrorReason.SaveCustomerError);
                    case CustomerOperationException.CustomerOperationError.LoadCustomerError:
                        throw new BusinessLayerException(ErrorReason.LoadCustomerError);
                    default:
                        throw;
                }
            }
            catch (OrderOperationException ex)
            {
                switch (ex.Error)
                {
                    case OrderOperationException.OrderOperationError.SaveOrderError:
                        throw new BusinessLayerException(ErrorReason.SaveOrderError);
                    case OrderOperationException.OrderOperationError.LoadOrderError:
                        throw new BusinessLayerException(ErrorReason.LoadOrderError);
                    default:
                        throw;
                }
            }
        }
    }
}
