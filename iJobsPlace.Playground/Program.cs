using System;
using iJobsPlace.Entities.Accounts;

namespace iJobsPlace.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var profile = new Profile();
            
            var employer = new Employer();
             

          // user.Addresses.First().City.Country.Coordinate.Latitude



            Console.WriteLine(user.DateOfBirth == null ? "Date Of Birth is NULL" : "***");
            Console.WriteLine(user.Email == null ? "Email is NULL" : "###");

            Console.WriteLine(user.DateOfBirth);


            //--Zeeshan
            //Line 1: Date of Birth is NULL
            //Line 2: Email is NULL

            //--Liaqat 
            //Line 1: Date of Birth is NULL
            //Line 2: Email is NULL

            //--CH 
            //Line 1: ***
            //Line 2: ###

            //--Ehsan 
            //Line 1: Date of Birth is NULL
            //Line 2: Email is NULL



            //Team Collaboration Tools





            Console.ReadKey();
        }
    }
}
