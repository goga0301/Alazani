using Alazani.Application.Features.Currency.Queries;

namespace Alazani.Application.Features.Currency.Handlers;

public class GetCurrenciesHandler : IRequestHandler<GetCurrenciesQuery, IApiResponse<IEnumerable<CurrencyModel>>>
{
    public async Task<IApiResponse<IEnumerable<CurrencyModel>>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
