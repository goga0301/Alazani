using Alazani.API.Controllers.Base;
using Alazani.Application.Features.Organization.Create;
using Alazani.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alazani.API.Controllers
{
    public class OrganizationController : BaseController
    {
        public OrganizationController(IMediator mediator, ILogger<OrganizationController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<IApiResponse> Create(CreateOrganizationCommand command)
        {
            var response = await _mediator.Send(command);
            return response;
        }

    }
}
