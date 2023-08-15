namespace Alazani.Application.Features.Currency.Delete;

public class DeleteCurrencyCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }
    public DeleteCurrencyCommand(int id)
    {
        Id = id;
    }
}