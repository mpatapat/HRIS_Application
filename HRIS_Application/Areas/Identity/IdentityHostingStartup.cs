using System;
using HRIS_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(HRIS_Application.Areas.Identity.IdentityHostingStartup))]
namespace HRIS_Application.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HRIS_ApplicationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HRIS_ApplicationContextConnection")));
                // Change to false for demo purposes
                services.AddDefaultIdentity<HRIS_ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    })
                    .AddEntityFrameworkStores<HRIS_ApplicationContext>();
            });
        }
    }
}