namespace Alazani.Application.Features.Currency.Read;

public class GetCurrencyQuery : IRequest<IApiResponse<CurrencyModel>>
{
    public int Id { get; set; }

    public GetCurrencyQuery(int id)
    {
        Id = id;
    }
}
