namespace Alazani.Application.Features.Currency;

public class CurrencyNotFoundException : Exception
{
    public CurrencyNotFoundException(string message) : base(message)
    {

    }
}
