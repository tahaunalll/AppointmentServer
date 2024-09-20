using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentServer.Domain.Entities;

namespace AppointmentServer.Domain.Repositories
{
    //IRepository
    public interface IDoctorRepository : IRepository<Doctor>
    {
    }
}
