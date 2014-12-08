using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Id { get; set; }

        public CustomerDto()
        {
            
        }

        public Customer ToDataLayerObject()
        {
            return new Customer { FirstName = this.FirstName, Id = this.Id, LastName = this.LastName };
        }
    }
}
