﻿namespace Alazani.Handlers.Currency.Handlers;

public class CreateCurrencyHandler : IRequestHandler<CreateCurrencyCommand, IApiResponse<int>>
{
    public async Task<IApiResponse<int>> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
