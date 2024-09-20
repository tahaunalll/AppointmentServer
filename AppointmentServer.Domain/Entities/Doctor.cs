using AppointmentServer.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentServer.Domain.Entities
{
    //bizim durumumuzda danışman bilgileri
    public sealed class Doctor
    {
        
        public Doctor()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => string.Join(" ", FirstName, LastName);
        public DepartmentEnum Department { get; set; } = DepartmentEnum.Acil;
    }
}
