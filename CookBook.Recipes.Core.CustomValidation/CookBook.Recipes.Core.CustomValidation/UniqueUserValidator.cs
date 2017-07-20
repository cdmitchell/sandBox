using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CookBook.Recipes.Core.CustomValidation;
using CookBook.Recipes.Core.CustomValidation.Repository;



namespace CookBook.Recipes.Core.CustomValidation
{
    public class UniqueUserValidator:ValidationAttribute
    {
        public IRepository Repository { get; set; }

        public UniqueUserValidator()
        {
            this.Repository = new MockRepository();
        }

        public override bool IsValid(object value)
        {
            string valueToTest = Convert.ToString(value);
            return this.Repository.IsUserNameUnique(valueToTest);
        }
    }
}