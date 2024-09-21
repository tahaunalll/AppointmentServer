using AppointmentServer.Domain.Entities;
using AppointmentServer.Domain.Repositories;
using AppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace AppointmentServer.Infrastructure.Repositories
{
    internal sealed class DoctorRepository : Repository<Doctor, ApplicationDbContext>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
