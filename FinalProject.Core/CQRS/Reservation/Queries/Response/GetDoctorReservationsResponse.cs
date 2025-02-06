namespace FinalProject.Core.CQRS.Reservation.Queries.Response;

public class GetDoctorReservationsResponse
{
    public string PatientName { get; set; }
    public TimeSpan ReservationDate { get; set; }
}