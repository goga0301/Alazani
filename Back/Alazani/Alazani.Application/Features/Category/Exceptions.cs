namespace Alazani.Application.Features.Category;

public class CategoryNotFoundException : Exception
{
    public CategoryNotFoundException(string message) : base(message)
    {

    }
}
