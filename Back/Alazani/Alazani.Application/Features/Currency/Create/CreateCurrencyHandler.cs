namespace Alazani.Application.Features.Currency.Create;

public class CreateCurrencyHandler : IRequestHandler<CreateCurrencyCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
