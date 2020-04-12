using System;
using AuthIdentityCustomized.Areas.Identity.Data;
using AuthIdentityCustomized.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuthIdentityCustomized.Areas.Identity.IdentityHostingStartup))]
namespace AuthIdentityCustomized.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthIdentityContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AuthIdentityContext>();
            });
        }
    }
}