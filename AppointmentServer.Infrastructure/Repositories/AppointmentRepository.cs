using AppointmentServer.Domain.Entities;
using AppointmentServer.Domain.Repositories;
using AppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace AppointmentServer.Infrastructure.Repositories
{
    internal sealed class AppointmentRepository : Repository<Appointment, ApplicationDbContext>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
