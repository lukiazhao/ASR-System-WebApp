using System;
using System.ComponentModel.DataAnnotations;

namespace AsrSystem.Models
{
    internal class ValidateDateRange : ValidationAttribute
    {
    
        public DateTime StartHour
        {
            get
            {
                return Convert.ToDateTime("09:00:00");
            }
            set { }
        }
        
        public DateTime EndHour
        {
            get
            {
                return StartHour.AddHours(5);
            }
            set { }
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // date has to be later than today and time has to be in range of 09:00 to 14:00
            DateTime _upcomingDateTime = Convert.ToDateTime(value);
            if (_upcomingDateTime < DateTime.Now || 
                _upcomingDateTime.Hour < StartHour.Hour || 
                _upcomingDateTime.Hour > EndHour.Hour)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}