using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake,
                                    string CarModel, string Dui, int SpeedingTicket, string CoverageType, string PhoneNumber, int QuoteValue = 50)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress) || string.IsNullOrEmpty(CarMake)
                || string.IsNullOrEmpty(CarModel) || string.IsNullOrEmpty(Dui) || string.IsNullOrEmpty(CoverageType))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (CustomersEntities db = new CustomersEntities())
                {
                    var quote = new Customer();

                    quote.FirstName = FirstName;
                    quote.LastName = LastName;
                    quote.EmailAddress = EmailAddress;
                    quote.DateOfBirth = DateOfBirth;
                    quote.CarYear = CarYear;
                    quote.CarMake = CarMake;
                    quote.CarModel = CarModel;
                    quote.Dui = Dui;
                    quote.SpeedingTicket = SpeedingTicket;
                    quote.CoverageType = CoverageType;
                    quote.QuoteValue = QuoteValue;

                    {
                        quote.QuoteValue = Convert.ToInt32(quote.QuoteValue = 50);

                        if (quote.DateOfBirth < DateTime.Now.AddYears(-25))
                        {
                            quote.QuoteValue += 25;
                        }
                        if (quote.DateOfBirth < DateTime.Now.AddYears(-18))
                        {
                            quote.QuoteValue += 100;
                        }
                        if (quote.DateOfBirth > DateTime.Now.AddYears(-100))
                        {
                            quote.QuoteValue += 25;
                        }
                        if (quote.CarYear < 2000)
                        {
                            quote.QuoteValue += 25;
                        }
                        if (quote.CarYear > 2015)
                        {
                            quote.QuoteValue += 25;
                        }
                        if (quote.CarMake.ToLower() == "Porsche")
                        {
                            quote.QuoteValue += 25;
                        }
                        if (quote.CarMake.ToLower() == "Porsche" && quote.CarModel.ToLower() == "911 Carrera")
                        {
                            quote.QuoteValue += 25;
                        }
                        if (quote.SpeedingTicket++ > 0)
                        {
                            quote.QuoteValue += 10;
                        }
                        if (quote.Dui.ToLower() == "Yes")
                        {
                            quote.QuoteValue = Convert.ToInt32(quote.QuoteValue * 1.25);
                        }
                        if (quote.CoverageType.ToLower() == "Full Coverage")
                        {
                            quote.QuoteValue = Convert.ToInt32(quote.QuoteValue * 1.5);
                        }
                            else 
                            {
                                 quote.QuoteValue = Convert.ToInt32(quote.QuoteValue * 1.0);
                            }
                        db.Customers.Add(quote);
                        db.SaveChanges();

                        return View("QuoteSubmitted");
                    }
                }
            }
        }
        public ActionResult Admin()
        {
            return View();
        }
    }
}