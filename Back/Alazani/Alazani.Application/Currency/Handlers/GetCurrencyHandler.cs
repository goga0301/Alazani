namespace Alazani.Application.Currency.Handlers;

public class GetCurrencyHandler : IRequestHandler<GetCurrencyQuery, IApiResponse<CurrencyModel>>
{
    public async Task<IApiResponse<CurrencyModel>> Handle(GetCurrencyQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
