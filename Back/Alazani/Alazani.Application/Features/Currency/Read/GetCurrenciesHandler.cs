namespace Alazani.Application.Features.Currency.Read;

public class GetCurrenciesHandler : IRequestHandler<GetCurrenciesQuery, IApiResponse<IEnumerable<CurrencyModel>>>
{
    private readonly ICurrencyRepository _currencyRepository;

    public GetCurrenciesHandler(ICurrencyRepository currencyRepository)
    {
        _currencyRepository = currencyRepository;
    }

    public async Task<IApiResponse<IEnumerable<CurrencyModel>>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
    {
        var entities = await _currencyRepository.GetAllAsync();

        return ApiResponse<IEnumerable<CurrencyModel>>
            .Success(entities.Select(x => x.ToModel()));
    }
}
