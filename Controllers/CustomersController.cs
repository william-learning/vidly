using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Mary Williams", Id = 2}
            };
            // ViewBag.Message = "Customers can be found here.";

            var viewModel = new CustomerViewModel
            {
                Customers = customer
            };
            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Mary Williams", Id = 2}
            };

            if (id > customer.Count)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer.Find(x => x.Id == id));
            }
        }
    }
}