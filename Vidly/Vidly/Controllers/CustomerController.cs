using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customers = GetCustomer();
            return View(customers);
        }

        [Route("Customer/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();

            }
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Michael" },
                new Customer { Id = 2, Name = "Nathalie" }
            };
        }


    }
}
