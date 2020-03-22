using iJobsPlace.Entities.Common;
using System;
using System.Collections.Generic;

namespace iJobsPlace.Entities.Accounts
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Address> Addresses { get; set; }

        public Profile Profile { get; set; }

    }
}
