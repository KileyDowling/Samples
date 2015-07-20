using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ModelValidation.Models.Attributes;

namespace ModelValidation.Models
{
    //[NoGarfieldOnMondays(ErrorMessage = "Garfield can not book appopintments on Mondays!")]
    //Model level attribute that you can put on the overall class.
        //checks class level last.  Runs through property validation before class levvel validation.
    public class Appointment : IValidatableObject
    {
        //[Required] //Data annotation
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Please enter a date")]//displays specific error message
        //[FutureDate(ErrorMessage = "You must enter a date in the future")]
        public DateTime Date { get; set; }

        //[MustBeTrue(ErrorMessage = "You must accept the terms")]//Created your own validtation attribute in MustBeTrueAttribute class
        public bool TermsAccepted { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>(); //Self Validating models example. Not really used...

            if (string.IsNullOrEmpty(ClientName))
            {
                errors.Add(new ValidationResult("Please enter your name", new[] {"ClientName"}));
            }

            if (DateTime.Now > Date)
            {
                errors.Add(new ValidationResult("Please enter a date in the future", new[] {"Date"}));
            }

            if (errors.Count == 0 && ClientName == "Garfield" && Date.DayOfWeek == DayOfWeek.Monday)
            {
                errors.Add(new ValidationResult("No Garfield on Mondays"));
            }

            if (!TermsAccepted)
            {
                errors.Add(new ValidationResult("You must accept the terms", new[] {"TermsAccepted"}));
            }

            return errors;
        }
    }
}