using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            using (CustomersEntities db = new CustomersEntities())
            {
                var signups = db.Customers;
                var quoteVMs = new List<QuoteVM>();
                foreach (var signup in signups)
                {
                    var signupVm = new QuoteVM();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVm.DateOfBirth = signup.DateOfBirth;
                    signupVm.QuoteValue = signup.QuoteValue;
                    signupVm.CarYear = signup.CarYear;
                    signupVm.CarMake = signup.CarMake;
                    signupVm.CarModel = signup.CarModel;
                    
                    quoteVMs.Add(signupVm);
                }
                return View(quoteVMs);
            }
        }
    }
}
