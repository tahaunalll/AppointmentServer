using AppointmentServer.Domain.Entities;


namespace AppointmentServer.Application.Services
{
    public interface IJwtProvider
    {
        public string CreateToken(AppUser user);
    }
}
