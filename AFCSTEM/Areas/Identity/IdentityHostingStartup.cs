using System;
using AFCSTEM.Areas.Identity.Data;
using AFCSTEM.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AFCSTEM.Areas.Identity.IdentityHostingStartup))]
namespace AFCSTEM.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<ApplicationDbContext>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("ApplicationDbContextConnection")));

                //services.AddDefaultIdentity<ApplicationUser>()
                //    .AddEntityFrameworkStores<ApplicationDbContext>();
            });
        }
    }
}