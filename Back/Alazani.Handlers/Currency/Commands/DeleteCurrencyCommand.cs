namespace Alazani.Handlers.Currency.Commands;

public class DeleteCurrencyCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }
    public DeleteCurrencyCommand(int id)
    {
        Id = id;
    }
}