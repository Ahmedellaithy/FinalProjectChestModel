namespace FinalProject.Core.CQRS.Doctor.Queries.Response;

public class GetDoctorPaginatedResponse
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
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public GetDoctorPaginatedResponse(string fullName, int yearsOfExperience,
        string degree, string specialty, string focus, string profile, string careerPath,
        string highlights, byte[] profilePicture, string email, string phoneNumber)
    {
        FullName = fullName;
        YearsOfExperience = yearsOfExperience;
        Degree = degree;
        Specialty = specialty;
        Focus = focus;
        Profile = profile;
        CareerPath = careerPath;
        Highlights = highlights;
        ProfilePicture = profilePicture;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}