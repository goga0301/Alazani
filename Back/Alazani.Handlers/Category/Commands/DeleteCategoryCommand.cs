﻿namespace Alazani.Handlers.Category.Commands;

public class DeleteCategoryCommand : IRequest<IApiResponse<bool>>
{
    public int Id { get; set; }

    public DeleteCategoryCommand(int id)
    {
        Id = id;
    }
}
