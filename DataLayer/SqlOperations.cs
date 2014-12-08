using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SqlOperations
    {
        public void SaveCustomer(Customer customer)
        {
            // 50% of the time we want this method to throw a SQL exception
            if (new Random().Next(2) == 0)
            {
                // Made up values that will trigger a SqlException
                using (SqlConnection conn = new SqlConnection("Server=sdfshfohwfohwfo;Database=sokldfjwisojf"))
                {
                    // Generate a SQL exception
                    conn.Open();
                }
            }
        }
    }
}