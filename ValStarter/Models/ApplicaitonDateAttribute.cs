using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValStarter.Models
{
    public class ApplicaitonDateAttribute : ValidationAttribute, IClientModelValidator
    {

        protected override ValidationResult IsValid(object Date, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;

            if (student.ApplicationDate > DateTime.Now.Date)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-applicationDate", GetErrorMessage());
        }

        private string GetErrorMessage()
        {
            return $"Date must be in the past";
        }

    }
}

