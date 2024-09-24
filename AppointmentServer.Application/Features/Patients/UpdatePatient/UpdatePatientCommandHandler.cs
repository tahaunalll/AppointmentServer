using AppointmentServer.Domain.Entities;
using AppointmentServer.Domain.Repositories;
using AutoMapper;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AppointmentServer.Application.Features.Patients.UpdatePatient
{
    internal sealed class UpdatePatientCommandHandler (
        IPatientRepository patientRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper) : IRequestHandler<UpdatePatientCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
        {
            Patient? patient = await patientRepository
                .GetByExpressionWithTrackingAsync(p => p.ID == request.Id, cancellationToken);

            if (patient is null)
            {
                return Result<string>.Failure("Patient not found");
                
            }

            if (patient.IdentityNumber != request.IdentityNumber )
            {
                if(patientRepository.Any(p=>p.IdentityNumber == request.IdentityNumber))
                {
                    return Result<string>.Failure("This identy number aldready used");
                }
            }

            mapper.Map(request, patient);
            patientRepository.Update(patient);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Patient update is successful";
        }
    }
}
