using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookBook.Recipes.Core.CustomValidation.Repository;

namespace CookBook.Recipes.Core.CustomValidation.Repository
{
    public class MockRepository:IRepository
    {
        #region Variables
        private static List<User> _users;
        
        #endregion
        public MockRepository()
        {
            _users = new List<User>();
            _users.Add(new User(){ UserName = "wayne27", 
                                   DateOfBirth = new DateTime(1950,9,27),
                                   Password = "knight"
                                 });
            _users.Add(new User(){UserName = "wayne47",
                                  DateOfBirth = new DateTime(1955, 9, 27),
                                  Password = "justice"
            });
        }

        #region IRepository Members
        public void AddUser(User user)
        {
            _users.Add(user);
        }
        /// <summary>
        /// Check whether a user with the username already exists
        /// </summary>
        /// < param name="username"></param>
        /// <returns></returns>
        public bool IsUserNameUnique(string userName)
        {
            bool exists = _users.Exists(u => u.UserName == userName);
            return !exists;
        }
        
        #endregion
    }
}
