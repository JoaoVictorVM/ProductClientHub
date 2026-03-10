namespace ProductClientHub.Exceptions.ExceptionsBase;

public class ErrorOnValidantionException : ProductClientHubExceptions
{

    private readonly List<string> _errors;

    public ErrorOnValidantionException(List<string> errorMessages) : base(string.Empty)
    {
        _errors = errorMessages;
    }

    public override List<string> GetErrors() => _errors;
}
