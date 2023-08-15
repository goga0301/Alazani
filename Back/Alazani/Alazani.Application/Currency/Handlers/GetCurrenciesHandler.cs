namespace Alazani.Application.Currency.Handlers;

public class GetCurrenciesHandler : IRequestHandler<GetCurrenciesQuery, IApiResponse<IEnumerable<CurrencyModel>>>
{
    public async Task<IApiResponse<IEnumerable<CurrencyModel>>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
