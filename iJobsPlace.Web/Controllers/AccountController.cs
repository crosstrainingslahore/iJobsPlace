using iJobsPlace.Services.Interfaces;
using iJobsPlace.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace iJobsPlace.Web.Controllers
{
    public class AccountController : Controller
    {

        //Dependency Injection
        //1: Ninject 
        //2: AutoFact


        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            var user = _accountService.GetProfileInfo();
            //Moving Data from Entity Class Object to View Model Class Object
            var profileViewModel = new ProfileViewModel()
            {
                Name = $"{user.FirstName} {user.LastName}",
                Email = user.Email,
                City = user.Addresses[0].City.Name
            };

            return View(profileViewModel);
        }

    }
}