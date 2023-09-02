namespace Alazani.Application.Features.Category.Create;

internal class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidator()
    {
        RuleFor(x => x.Model.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

        RuleFor(x => x.Model.Description)
            .MaximumLength(500).WithMessage("Description must not exceed 500 characters.");

        RuleFor(x => x.Model.OrganizationId)
            .NotEmpty().WithMessage("OrganizationId is required")
            .GreaterThan(0).WithMessage("OrganizationId must be greater than 0");
    }
}
