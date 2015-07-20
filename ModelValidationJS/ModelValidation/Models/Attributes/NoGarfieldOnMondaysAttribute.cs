using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models.Attributes
{
    public class NoGarfieldOnMondaysAttribute :ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Appointment app = value as Appointment;//as makes the value an appointment type
            if (app == null || string.IsNullOrEmpty(app.ClientName))
            {
                return true;
                //we want to skip this validation if there are other problems with validation
            }
            else
            {
                return !(app.ClientName == "Garfield" && app.Date.DayOfWeek == DayOfWeek.Monday);
                //as long as it is not garfield or monday
            }
        }
    }
}