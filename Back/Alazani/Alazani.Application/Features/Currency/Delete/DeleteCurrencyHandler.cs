namespace Alazani.Application.Features.Currency.Delete;

public class DeleteCurrencyHandler : IRequestHandler<DeleteCurrencyCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}