using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models.Attributes
{
    public class NoGarfieldOnMondays : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Appointment app = value as Appointment;
            if (app == null || string.IsNullOrEmpty(app.ClientName))
            {
                return true;
            }
            else
            {
                return !(app.ClientName == "Garfield" && app.Date.DayOfWeek == DayOfWeek.Monday);
            }
        }
    }
}