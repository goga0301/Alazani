namespace Alazani.Handlers.Currency.Commands;

public class UpdateCurrencyCommand : IRequest<IApiResponse<bool>>
{
    public UpdateCurrencyModel Model { get; set; }
    public UpdateCurrencyCommand(UpdateCurrencyModel model)
    {
        Model = model;
    }
}
