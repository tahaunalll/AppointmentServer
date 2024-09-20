using GenericRepository;
using AppointmentServer.Domain.Entities;

namespace AppointmentServer.Domain.Repositories
{
    public interface IPatientRepository : IRepository<Patient>
    {
    }
}
