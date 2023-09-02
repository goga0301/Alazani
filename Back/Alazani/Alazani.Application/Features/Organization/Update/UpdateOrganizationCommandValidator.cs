namespace Alazani.Application.Features.Organization.Update;

public class UpdateOrganizationCommandValidator : AbstractValidator<UpdateOrganizationCommand>
{
    public UpdateOrganizationCommandValidator(IOrganizationRepository organizationRepository)
    {
        RuleFor(x => x.Model.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

        RuleFor(x => x.Model.Description)
            .MaximumLength(500).WithMessage("Description must not exceed 500 characters.");

        RuleFor(x => x.Model.Address)
            .MaximumLength(500).WithMessage("Address must not exceed 500 characters.");

        RuleFor(x => x.Model.Name).MustAsync(async (name, _) =>
        {
            return !(await organizationRepository.AnyAsync(e => e.Name == name));
        }).WithMessage("Organization with this name already exists.");
    }
}
