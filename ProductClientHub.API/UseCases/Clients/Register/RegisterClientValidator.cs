using FluentValidation;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<Communication.Request.RequestClientJson>
{

    public RegisterClientValidator()
    {

        RuleFor(client => client.Name)
            .NotEmpty()
            .WithMessage("O nome do cliente é obrigatório.");
            
        RuleFor(client => client.Email)
            .EmailAddress()
            .WithMessage("O email do cliente é inválido.");

    }

}
