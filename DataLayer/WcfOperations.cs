using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class WcfOperations
    {
        public void SaveCustomer(Customer customer)
        {
            BasicHttpBinding myBinding = new BasicHttpBinding();
            // Made up URL that will trigger a ServiceModel exception when we call wcfClient.SaveCustomer(customer)
            EndpointAddress myEndpoint = new EndpointAddress("http://ejhgfeigheghoigh/CustomerService");
            ChannelFactory<ICustomerService> myChannelFactory = new ChannelFactory<ICustomerService>(myBinding, myEndpoint);
            ICustomerService wcfClient = myChannelFactory.CreateChannel();
            // Generate a WCF exception
            wcfClient.SaveCustomer(customer);
        }
    }
}