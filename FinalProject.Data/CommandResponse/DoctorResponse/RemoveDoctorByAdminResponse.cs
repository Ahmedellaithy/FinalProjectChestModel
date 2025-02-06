namespace FinalProject.Data.DoctorResponse;

public class RemoveDoctorByAdminResponse
{
    public string FullName { get; set; }
    public int YearsOfExperience { get; set; }
    public string Degree { get; set; }
    public string Specialty { get; set; }
    public string Focus { get; set; }
    public string Profile { get; set; }
    public string CareerPath { get; set; }
    public string Highlights { get; set; }
    public byte[] ProfilePicture { get; set; }
    public TimeSpan AvailableFrom { get; set; }
    public TimeSpan AvailableTo { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}