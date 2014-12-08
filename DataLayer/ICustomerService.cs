using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void SaveCustomer(Customer customer);
    }
}
