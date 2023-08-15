namespace Alazani.Application.Currency.Commands;

public class UpdateCurrencyCommand : IRequest<IApiResponse<bool>>
{
    public UpdateCurrencyModel Model { get; set; }
    public UpdateCurrencyCommand(UpdateCurrencyModel model)
    {
        Model = model;
    }
}
