using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class QuoteVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int QuoteValue { get; set; }
        public int  CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }

    }
}