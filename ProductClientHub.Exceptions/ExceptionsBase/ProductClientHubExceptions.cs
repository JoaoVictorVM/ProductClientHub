namespace ProductClientHub.Exceptions.ExceptionsBase;

public abstract class ProductClientHubExceptions : SystemException
{

    public ProductClientHubExceptions(string errorMessage) : base(errorMessage)
    {  
    }

    public abstract List<string> GetErrors();

}
