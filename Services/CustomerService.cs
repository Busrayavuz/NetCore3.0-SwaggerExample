using swaggerCore.Models;
using System.Collections.Generic;

namespace swaggerCore.Services
{
    public class CustomerService : ICustomerService
    {
        public static List<Customer> _customerList = new List<Customer>(){
        new Customer(){Id=1,Name="TestUserName1",Surname="TestUsername1",Email="test1@gmail.com",Phone="12345678901",Address="TestAdres1"},
        new Customer(){Id=2,Name="TestUserName2",Surname="TestUsername2",Email="test2@gmail.com",Phone="12345678902",Address="TestAdres2"},
        new Customer(){Id=3,Name="TestUserName3",Surname="TestUsername3",Email="test3@gmail.com",Phone="12345678903",Address="TestAdres3"}
    };

        public void CreateCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerList;
        }

        public Customer GetById(int id)
        {
            return _customerList.Find(x => x.Id == id);
        }
    }
}
