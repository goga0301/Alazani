﻿namespace Alazani.Application.Features.Category.Create;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, IApiResponse<int>>
{
    public Task<IApiResponse<int>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}