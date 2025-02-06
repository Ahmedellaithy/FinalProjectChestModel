using FinalProject.Core.Pagination;


namespace FinalProject.Core.CQRS.Doctor.Queries.Response;

public class GetDoctorListResponse
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int YearsOfExperience { get; set; }
    public string Degree { get; set; }
    public string specialty { get; set; }
    public string Focus { get; set; }
    public string Profile { get; set; }
    public string CareerPath { get; set; }
    public string Highlights { get; set; }
    public byte[] ProfilePicture { get; set; }
    public DateTime AvailableFrom { get; set; }
    public DateTime AvailableTo { get; set; }


}