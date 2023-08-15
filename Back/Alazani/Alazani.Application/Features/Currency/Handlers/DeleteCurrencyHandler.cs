using Alazani.Application.Features.Currency.Commands;

namespace Alazani.Application.Features.Currency.Handlers;

public class DeleteCurrencyHandler : IRequestHandler<DeleteCurrencyCommand, IApiResponse<bool>>
{
    public async Task<IApiResponse<bool>> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}