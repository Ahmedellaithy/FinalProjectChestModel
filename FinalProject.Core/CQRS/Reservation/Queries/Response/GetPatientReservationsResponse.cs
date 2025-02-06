using FinalProject.Data.Enums.Reservation;

namespace FinalProject.Core.CQRS.Reservation.Queries.Response;

public class GetPatientReservationsResponse
{
    public string DoctorName { get; set; }
    public DateTime ReservationDate { get; set; }
}
