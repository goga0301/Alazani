using Alazani.API.Controllers.Base;
using Alazani.Application.Features.Organization.Create;
using Alazani.Application.Features.Organization.Delete;
using Alazani.Application.Features.Organization.Read;
using Alazani.Application.Features.Organization.Update;
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

        [HttpPut]
        public async Task<IApiResponse> Update(UpdateOrganizationCommand command)
        {
            var response = await _mediator.Send(command);
            return response;
        }

        [HttpGet("{id}")]
        public async Task<IApiResponse> Get(int id)
        {
            var response = await _mediator.Send(new GetOrganizationQuery (id));
            return response;
        }

        [HttpGet]
        public async Task<IApiResponse> GetAll()
        {
            var response = await _mediator.Send(new GetOrganizationsQuery());
            return response;
        }


        [HttpDelete("{id}")]
        public async Task<IApiResponse> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteOrganizationCommand(id));
            return response;
        }
    }
}
