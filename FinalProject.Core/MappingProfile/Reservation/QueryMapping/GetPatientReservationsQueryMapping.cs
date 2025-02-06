using FinalProject.Core.CQRS.Reservation.Queries.Response;

namespace FinalProject.Core.MappingProfile.Reservation;

public partial class ReservationMapping
{
    public void GetPatientReservationsQueryMapping()
    {
        CreateMap<Data.Models.Reservation, GetPatientReservationsResponse>()
            .ForMember(dest=>dest.ReservationDate,x=>x.MapFrom(src=>src.ReservationDate))
            .ForMember(dest => dest.DoctorName, x=>x.MapFrom(src => src.Doctor.FullName))
            .ReverseMap();
    }
}
