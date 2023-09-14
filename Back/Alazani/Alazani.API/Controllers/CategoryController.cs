using Alazani.API.Controllers.Base;
using Alazani.Application.Features.Category.Create;
using Alazani.Application.Features.Category.Delete;
using Alazani.Application.Features.Category.Read;
using Alazani.Application.Features.Category.Update;
using Alazani.Shared.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alazani.API.Controllers
{
    public class CategoryController : BaseController
    {
        protected CategoryController(IMediator mediator, ILogger<BaseController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<IApiResponse> Create(CreateCategoryCommand command)
        {
            var response = await Mediator.Send(command);
            return response;
        }

        [HttpPut]
        public async Task<IApiResponse> Update(UpdateCategoryCommand command)
        {
            var response = await Mediator.Send(command);
            return response;
        }

        [HttpGet("{id}")]
        public async Task<IApiResponse> Get(int id)
        {
            var response = await Mediator.Send(new GetCategoryQuery(id));
            return response;
        }

        [HttpGet]
        public async Task<IApiResponse> GetAll()
        {
            var response = await Mediator.Send(new GetCategoriesQuery());
            return response;
        }


        [HttpDelete("{id}")]
        public async Task<IApiResponse> Delete(int id)
        {
            var response = await Mediator.Send(new DeleteCategoryCommand(id));
            return response;
        }
    }
}
