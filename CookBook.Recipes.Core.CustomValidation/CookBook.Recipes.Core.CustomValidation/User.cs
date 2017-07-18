using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CookBook.Recipes.Core.CustomValidation
{
    /// <summary>
    /// Contains details of the user being registered
    /// </summary>
    public class User
    {
        [UniqueUserValidator(ErrorMessage="User name already exists")]
        public string UserName { get; set;}
        public DateTime DateOfBirth { get; set;}
        public string Password { get; set;}
    }
}
