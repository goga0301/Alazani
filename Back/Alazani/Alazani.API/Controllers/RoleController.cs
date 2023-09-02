using Alazani.API.Controllers.Base;
using Alazani.Application.Features.Role.Create;
using Alazani.Application.Features.Role.Delete;
using Alazani.Application.Features.Role.Read;
using Alazani.Application.Features.Role.Update;
using Alazani.Shared.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alazani.API.Controllers
{
    public class RoleController : BaseController
    {
        public RoleController(IMediator mediator, ILogger<BaseController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<IApiResponse> Create(CreateRoleCommand command)
        {
            var response = await Mediator.Send(command);
            return response;
        }

        [HttpPut]
        public async Task<IApiResponse> Update(UpdateRoleCommand command)
        {
            var response = await Mediator.Send(command);
            return response;
        }

        [HttpDelete]
        public async Task<IApiResponse> Delete(int id)
        {
            var response = await Mediator.Send(new DeleteRoleCommand(id));
            return response;
        }

        [HttpGet]
        public async Task<IApiResponse> GetAll()
        {
            var response = await Mediator.Send(new GetRolesQuery());
            return response;
        }

        [HttpGet("{id}")]
        public async Task<IApiResponse> Get(int id)
        {
            var response = await Mediator.Send(new GetRoleQuery(id));
            return response;
        }



    }
}
