using swaggerCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swaggerCore.Services
{
   public  interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        void CreateCustomer(Customer customer);
    }
}
