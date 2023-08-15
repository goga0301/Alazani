namespace Alazani.Application.Features.Currency.Handlers;

public class UpdateCurrencyHandler : IRequestHandler<UpdateCurrencyCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
