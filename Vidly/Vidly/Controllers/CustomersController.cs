using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Customers()
        {
            List<Customer> customersList = GetCustomers();

            return View(customersList);
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(x => x.Id == id);
            if (customers == null)
                return HttpNotFound();

            return View(customers);
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customersList = new List<Customer>()
            {
                new Customer(){ Id = 1, Name = "John Smith"},
                new Customer(){ Id = 2, Name = "Mary Williams"}
            };
            return customersList;
        }

    }
}