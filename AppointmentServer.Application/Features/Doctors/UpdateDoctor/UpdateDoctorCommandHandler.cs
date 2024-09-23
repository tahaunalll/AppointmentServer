using AppointmentServer.Domain.Entities;
using AppointmentServer.Domain.Repositories;
using AutoMapper;
using GenericRepository;
using MediatR;
using TS.Result;

namespace AppointmentServer.Application.Features.Doctors.UpdateDoctor
{
    internal sealed class UpdateDoctorCommandHandler(
        IDoctorRepository doctorRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper) : IRequestHandler<UpdateDoctorCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
        {
            //update olacağı için 
            Doctor? doctor = await doctorRepository.GetByExpressionWithTrackingAsync(p => p.ID == request.Id, cancellationToken);
            if (doctor == null)
            {
                return Result<string>.Failure("Doctor not found");
            }

            mapper.Map(request,doctor);

            doctorRepository.Update(doctor);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return "Doctor update is successful";
        }
    }
}
