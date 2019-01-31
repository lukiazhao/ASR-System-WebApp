using System;
using System.ComponentModel.DataAnnotations;

namespace AsrSystem.Models
{
    internal class ValidateHourAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Slots have to be at the start of the hour
            DateTime _upcomingDateTime = Convert.ToDateTime(value);
            if (_upcomingDateTime.Minute != 0 || _upcomingDateTime.Second != 0)
                return new ValidationResult(ErrorMessage);
            return ValidationResult.Success;
        }
    }
}