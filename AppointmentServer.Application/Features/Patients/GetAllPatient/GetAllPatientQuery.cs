using AppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace AppointmentServer.Application.Features.Patients.GetAllPatient
{
    public sealed record GetAllPatientQuery() : IRequest<Result<List<Patient>>>;
}
