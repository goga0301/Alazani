namespace Alazani.Handlers.Currency.Commands;

public class CreateCurrencyCommand : IRequest<IApiResponse<int>>
{
    public CreateCurrencyModel Model { get; set; }

    public CreateCurrencyCommand(CreateCurrencyModel model)
    {
        Model = model;
    }
}
