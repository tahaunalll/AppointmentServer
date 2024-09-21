using AppointmentServer.Domain.Entities;
using AppointmentServer.Domain.Repositories;
using AppointmentServer.Infrastructure.Context;
using GenericRepository;

namespace AppointmentServer.Infrastructure.Repositories
{
    internal sealed class PatientRepository : Repository<Patient, ApplicationDbContext>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
