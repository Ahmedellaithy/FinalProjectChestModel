using FinalProject.Data.Enums.Patient;

namespace FinalProject.Core.CQRS.Authentication.Commands.Response;

public class RegisterResponse
{
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public Gender? Gender { get; set; }
}