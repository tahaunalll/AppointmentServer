using AppointmentServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace AppointmentServer.WebAPI
{
    public static class Helper
    {
        public static async Task CreateUser(this WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                if (!userManager.Users.Any())
                {
                    await userManager.CreateAsync(new()
                    {
                        FirstName = "Taha Turgut",
                        LastName = "Ünal",
                        Email = "admin@admin.com",
                        UserName = "admin",
                    }, "1");


                }
            }
        }
    }
}
