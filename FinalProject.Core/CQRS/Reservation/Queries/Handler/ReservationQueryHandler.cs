using AutoMapper;
using FinalProject.Core.CQRS.Reservation.Queries.Request;
using FinalProject.Core.CQRS.Reservation.Queries.Response;
using FinalProject.Service.Interfaces;
using MediatR;
using SchoolProject.Core.Bases;

namespace FinalProject.Core.CQRS.Reservation.Queries.Handler;

public class ReservationQueryHandler : ExtraResponseHandler,
                                       IRequestHandler<GetPatientReservationsQuery,ExtraResponseOutput<ICollection<GetPatientReservationsResponse>>>,
                                       IRequestHandler<GetDoctorReservationsQuery,ExtraResponseOutput<List<GetDoctorReservationsResponse>>>
{
    
    private readonly IMapper _mapper;
    private readonly IReservationService _service;
    public ReservationQueryHandler(IMapper mapper, IReservationService service)
    {
        _mapper = mapper;
        _service = service;
    }
    
    public async Task<ExtraResponseOutput<ICollection<GetPatientReservationsResponse>>> Handle(GetPatientReservationsQuery request, CancellationToken cancellationToken)
    {
        var reservations = await _service.GetPatientReservationsAsync(request.Id);
        if(reservations == null) return NotFound<ICollection<GetPatientReservationsResponse>>("Patient didn't make any reservations");
        
        var mappedReservations = _mapper.Map<ICollection<GetPatientReservationsResponse>>(reservations);
        
        return Success(mappedReservations);
    }

    public async Task<ExtraResponseOutput<List<GetDoctorReservationsResponse>>> Handle(GetDoctorReservationsQuery request, CancellationToken cancellationToken)
    {
        var reservations = await _service.GetDoctorReservationsAsync(request.Id);
        if (reservations == null) return NotFound<List<GetDoctorReservationsResponse>>("The doctor didn't have any reservations");
        
        var mappedReservations = _mapper.Map<List<GetDoctorReservationsResponse>>(reservations);
        return Success(mappedReservations);
    }
}