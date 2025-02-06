using AutoMapper;
using FinalProject.Core.CQRS.Patient.Commands.Request;
using FinalProject.Data.PatientResponse;
using FinalProject.Service.Interfaces;
using MediatR;
using SchoolProject.Core.Bases;

namespace FinalProject.Core.CQRS.Patient.Commands.Handler;

public class PatientCommandHandler : ExtraResponseHandler,
                                     IRequestHandler<UpdatePatientCommand,ExtraResponseOutput<UpdatePatientResponse>>
{
    private readonly IMapper _mapper;
    private readonly IPatientService _service;
    public PatientCommandHandler(IMapper mapper, IPatientService service)
    {
        _mapper = mapper;
        _service = service;
    }
    
    
    public async Task<ExtraResponseOutput<UpdatePatientResponse>> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
    {
        var patient = await _service.GetPatientByIdWithIncludeAsync(request.Id);
        
        patient.FullName=request.FullName;
        await _service.UpdatePatientAsync(patient);
        await _service.SaveChangesAsync();

        var mappeedPatient = _mapper.Map<UpdatePatientResponse>(patient);
        return Success(mappeedPatient);
    }
}