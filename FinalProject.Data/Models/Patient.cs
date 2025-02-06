using System.ComponentModel.DataAnnotations.Schema;
using FinalProject.Data.Enums.Patient;
using FinalProject.Data.Identity;
using Microsoft.AspNetCore.Http;

namespace FinalProject.Data.Models;

public class Patient
{
    public int Id { get; set; }
    public int ApplicationUserId { get; set; }
    public string FullName { get; set; }
    public byte[]? ProfilePicture { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    
    public virtual ApplicationUser ApplicationUser { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}