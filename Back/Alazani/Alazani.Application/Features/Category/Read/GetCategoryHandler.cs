﻿namespace Alazani.Application.Features.Category.Read;

public class GetCategoryHandler : IRequestHandler<GetCategoryQuery, IApiResponse<CategoryModel>>
{
    public Task<IApiResponse<CategoryModel>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
