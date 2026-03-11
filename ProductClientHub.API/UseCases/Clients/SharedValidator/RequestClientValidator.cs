using FluentValidation;

namespace ProductClientHub.API.UseCases.Clients.SharedValidator;

public class RequestClientValidator : AbstractValidator<Communication.Request.RequestClientJson>
{

    public RequestClientValidator()
    {

        RuleFor(client => client.Name)
            .NotEmpty()
            .WithMessage("O nome do cliente é obrigatório.");
            
        RuleFor(client => client.Email)
            .EmailAddress()
            .WithMessage("O email do cliente é inválido.");

    }

}
