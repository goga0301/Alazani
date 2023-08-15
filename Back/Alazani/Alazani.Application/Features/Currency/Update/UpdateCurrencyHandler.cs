namespace Alazani.Application.Features.Currency.Update;

public class UpdateCurrencyHandler : IRequestHandler<UpdateCurrencyCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
