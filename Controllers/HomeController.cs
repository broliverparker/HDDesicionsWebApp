using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HDDesicions.Models;

namespace HDDesicions.Controllers
{
    public class HomeController : Controller
    {
        Applicant applicant = new Applicant();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Apply()
        {
            return View(applicant);
        }

        public ActionResult Result(string fname, string lname, string dob, string income)
        {
            applicant.FirstName = fname;
            applicant.LastName = lname;
            applicant.DOB = dob;
            applicant.Income = income;

            return View(applicant);
        }

        public ActionResult PreviousResult()
        {
            return View();
        }
    }
}