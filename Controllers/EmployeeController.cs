using EmployeeProject_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace EmployeeProject_2.Controllers
{
    public class EmployeeController : Controller
    {
       public ActionResult EnterNewEmployeeDetails()
        {
            Employee e = new Employee();
            return View(e);
        }
        public ActionResult SaveEmployeeDetails(Employee e)
        {
            if (ModelState.IsValid)
            {
                return View("DisplayEmployeeDetails", e);
            }
            else
            {
                return View("EnterNewEmployeeDetails", e);
            }
        }
    }
}