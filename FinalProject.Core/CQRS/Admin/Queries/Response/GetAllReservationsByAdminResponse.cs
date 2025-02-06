namespace FinalProject.Core.CQRS.Admin.Queries.Response;

public class GetAllReservationsByAdminResponse
{
    public string PatientName { get; set; }
    public string DoctorName { get; set; }
    public TimeSpan ReservationDate { get; set; }
}