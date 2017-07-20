using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBook.Recipes.Core.CustomValidation
{
    public interface IRepository
    {
        void AddUser(User user);
        bool IsUserNameUnique(string name);
    }
}
