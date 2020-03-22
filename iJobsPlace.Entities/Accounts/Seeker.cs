using System.Collections.Generic;

namespace iJobsPlace.Entities.Accounts
{
    public class Seeker : User
    {
        public PersonalInformation PersonalInfo { get; set; }
        public List<EducationInformation> EducationInformation { get; set; }
        public List<ExperienceInformation> ExperienceInformation { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Hobby> Hobbies { get; set; }
        public List<Language> Languages { get; set; }
        public List<Certification> Certifications { get; set; }

    }
}