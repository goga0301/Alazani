using Alazani.Domain.Repository;
using FluentValidation;

namespace Alazani.Application.Features.Organization.Delete;

public class DeleteOrganizationCommandValidator : AbstractValidator<DeleteOrganizationCommand>
{
    public DeleteOrganizationCommandValidator(IOrganizationRepository _organizationRepository)
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required")
            .GreaterThan(0).WithMessage("Id must be greater than 0")
            .MustAsync(async (id, _) =>
            {
                return !(await _organizationRepository.AnyAsync(x => x.Id == id));
            }).WithMessage($"Organization with this ID does not exist");

    }
}
