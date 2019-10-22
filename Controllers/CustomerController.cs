using Microsoft.AspNetCore.Mvc;
using swaggerCore.Models;
using swaggerCore.Services;
using System.Collections.Generic;

namespace swaggerCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }
        // GET api/GetAllClass
        [HttpGet("GetAll")]
        public ActionResult<List<Customer>> GetAll()
        {
            return _customerService.GetAll();
        }     

        [HttpGet("GetById/{id}")]
        public Customer GetById(int id)
        {
            return _customerService.GetById(id);
        }

        [HttpPost("CreateCustomer")]
        public void CreateCustomer([FromBody] Customer customer)
        {
            _customerService.CreateCustomer(customer);
        }
    }
}
