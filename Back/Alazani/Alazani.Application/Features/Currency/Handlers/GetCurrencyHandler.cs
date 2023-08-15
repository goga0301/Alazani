using Alazani.Application.Features.Currency.Queries;

namespace Alazani.Application.Features.Currency.Handlers;

public class GetCurrencyHandler : IRequestHandler<GetCurrencyQuery, IApiResponse<CurrencyModel>>
{
    public async Task<IApiResponse<CurrencyModel>> Handle(GetCurrencyQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
