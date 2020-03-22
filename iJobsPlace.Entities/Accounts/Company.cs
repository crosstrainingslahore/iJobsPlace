using System;
using iJobsPlace.Entities.Common;

namespace iJobsPlace.Entities.Accounts
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public DateTime EstDate { get; set; }
    }
}