using System;

namespace iJobsPlace.Entities.Accounts
{
    public class ExperienceInformation
    {
        public int Id { get; set; }

        public string Designation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ExperienceYears
        {
            get
            {
                return EndDate.Year - StartDate.Year;
            }
        }
        public Company Company { get; set; }
    }
}
