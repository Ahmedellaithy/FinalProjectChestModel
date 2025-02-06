using FinalProject.Core.CQRS.Authentication.Commands.Response;
using FluentValidation;

namespace FinalProject.Core.CQRS.Authentication.Commands.Validators;

public class SetNewPasswordValidator : AbstractValidator<SetNewPasswordCommand>
{
    public SetNewPasswordValidator()
    {
        SetNewPasswordValidate();
    }

    public void SetNewPasswordValidate()
    {
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("This field cannot be empty")
            .NotNull().WithMessage("This field cannot be null")
            .MinimumLength(6).MaximumLength(64);

        RuleFor(x => x.ConfirmPassword)
            .NotEmpty().WithMessage("This field cannot be empty")
            .NotNull().WithMessage("This field cannot be null")
            .Matches(x => x.Password);
    }
}