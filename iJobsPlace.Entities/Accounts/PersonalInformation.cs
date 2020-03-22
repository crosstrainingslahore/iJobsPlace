using iJobsPlace.Entities.Common;

namespace iJobsPlace.Entities.Accounts
{
    public class PersonalInformation
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Cnic { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
}
