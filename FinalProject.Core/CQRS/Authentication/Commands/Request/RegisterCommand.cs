using FinalProject.Data.Enums.Patient;
using MediatR;
using SchoolProject.Core.Bases;

namespace FinalProject.Core.CQRS.Authentication.Commands.Response;

public class RegisterCommand : IRequest<ExtraResponseOutput<RegisterResponse>>
{
    public string FullName { get; set; }
    public string Email { get; set; }   
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    
}