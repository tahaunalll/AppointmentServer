using AppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace AppointmentServer.Application.Features.Doctors.GetAllDoctor
{
    public sealed record GetAllDoctorQuery():IRequest<Result<List<Doctor>>>;
}
