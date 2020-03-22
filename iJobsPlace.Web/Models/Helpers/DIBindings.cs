using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iJobsPlace.Services.Implementations;
using iJobsPlace.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace iJobsPlace.Web.Models.Helpers
{
    public  class DIBindings
    {
        public  DIBindings(IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            //services.AddSingleton<IAccountService, AccountService>();

            //services.AddTransient<IAccountService, AccountService>();
        }
    }
}
