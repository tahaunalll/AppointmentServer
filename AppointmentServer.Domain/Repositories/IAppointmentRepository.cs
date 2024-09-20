using GenericRepository;
using AppointmentServer.Domain.Entities;

namespace AppointmentServer.Domain.Repositories
{
    //Taner Saydamın GenericRepository kütüphanesi:
    //TS.EntityFrameworkCore.GenericRepository
    public interface IAppointmentRepository : IRepository<Appointment>
    {
    }
}
