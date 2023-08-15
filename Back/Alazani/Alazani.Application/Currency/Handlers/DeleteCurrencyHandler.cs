namespace Alazani.Application.Currency.Handlers;

public class DeleteCurrencyHandler : IRequestHandler<DeleteCurrencyCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}