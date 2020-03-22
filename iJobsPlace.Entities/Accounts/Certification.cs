using System;
namespace iJobsPlace.Entities.Accounts
{
    public class Certification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Institute Institute { get; set; }
    }
}
