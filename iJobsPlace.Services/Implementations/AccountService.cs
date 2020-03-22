using iJobsPlace.Entities.Accounts;
using iJobsPlace.Entities.Common;
using iJobsPlace.Services.Interfaces;
using System.Collections.Generic;

namespace iJobsPlace.Services.Implementations
{
    public class AccountService : IAccountService
    {
        public User GetProfileInfo()
        {
            var user = new User()
            {
                Email = "IrshadAhmed31@outlook.com",
                FirstName = "Irshad",
                LastName = "Ahmed",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        City = new City()
                        {
                            Name = "Lahore"
                        }
                    }
                }
            };
            return user;
        }
    }
}
