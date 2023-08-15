namespace Alazani.Application.Features.Currency.Read;

public class GetCurrenciesHandler : IRequestHandler<GetCurrenciesQuery, IApiResponse<IEnumerable<CurrencyModel>>>
{
    public async Task<IApiResponse<IEnumerable<CurrencyModel>>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
