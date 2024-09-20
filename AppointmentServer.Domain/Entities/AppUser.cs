using Microsoft.AspNetCore.Identity;

namespace AppointmentServer.Domain.Entities
{
    //Identity kütüphanesini kullanacağımız için bu isimlendirmeyle açtık
    //class inherit edilmesin diye sealed
    //Identity kütüphanesini Nuget ten kur
    //Microsoft.AspNetCore.Identity.EntityFrameworkCore
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => string.Join(" ", FirstName, LastName);
    }
}
