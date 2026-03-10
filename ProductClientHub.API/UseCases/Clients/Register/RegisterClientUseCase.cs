using ProductClientHub.Communication.Response;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{

    public ResponseClientJson Execute(Communication.Request.RequestClientJson request)
    {

        var validator = new RegisterClientValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false)
        {

            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

            throw new ProductClientHub.Exceptions.ExceptionsBase.ErrorOnValidantionException(errors);
            
        }

        return new ResponseClientJson();

    }

}
