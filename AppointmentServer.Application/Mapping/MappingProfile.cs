using AppointmentServer.Application.Features.Doctors.CreateDoctor;
using AppointmentServer.Application.Features.Doctors.UpdateDoctor;
using AppointmentServer.Domain.Entities;
using AppointmentServer.Domain.Enums;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentServer.Application.Mapping
{
    internal class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateDoctorCommand, Doctor>()
                .ForMember(member => member.Department,
                options => options.MapFrom(map => DepartmentEnum.FromValue(map.DepartmentValue)));

            CreateMap<UpdateDoctorCommand, Doctor>()
                .ForMember(member => member.Department,
                options => options.MapFrom(map => DepartmentEnum.FromValue(map.DepartmentValue)));
        }

        //şuradaki işleme eş değer : 

        /*
        Doctor doctor = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Department = DepartmentEnum.FromValue(request.Department),
        };
        */


    }
}
