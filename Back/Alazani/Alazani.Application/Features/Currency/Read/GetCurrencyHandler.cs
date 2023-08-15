namespace Alazani.Application.Features.Currency.Read;

public class GetCurrencyHandler : IRequestHandler<GetCurrencyQuery, IApiResponse<CurrencyModel>>
{
    public async Task<IApiResponse<CurrencyModel>> Handle(GetCurrencyQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
