using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstResponsiveWebAppLastName.Models;

namespace FirstResponsiveWebAppLastName.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonModel person = new PersonModel();

            return View(person);
        }

        [HttpPost]
        public ActionResult Index(PersonModel person)
        {
            return View(person);
        }

        public ActionResult CalculateByDate()
        {
            PersonExactDateModel person = new PersonExactDateModel();

            return View(person);
        }

        [HttpPost]
        public ActionResult CalculateByDate(PersonExactDateModel personModel)
        {
            return View(personModel);
        }

    }
}