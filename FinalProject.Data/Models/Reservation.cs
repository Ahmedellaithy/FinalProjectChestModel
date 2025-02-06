using System.ComponentModel.DataAnnotations.Schema;
using FinalProject.Data.Enums.Reservation;

namespace FinalProject.Data.Models;

public class Reservation
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public TimeSpan ReservationDate { get; set; }
    public Status Status { get; set; }
    public bool IsAvailable { get; set; }
    
    
    public virtual Doctor Doctor { get; set; }
    public virtual Patient Patient { get; set; }
}