using Alazani.Application.Features.Currency.Commands;

namespace Alazani.Application.Features.Currency.Handlers;

public class CreateCurrencyHandler : IRequestHandler<CreateCurrencyCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
