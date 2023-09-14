using Alazani.API.Controllers.Base;
using Alazani.Application.Features.Currency.Create;
using Alazani.Application.Features.Currency.Delete;
using Alazani.Application.Features.Currency.Read;
using Alazani.Application.Features.Currency.Update;
using Alazani.Shared.Helpers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alazani.API.Controllers
{
    public class CurrencyController : BaseController
    {
        protected CurrencyController(IMediator mediator, ILogger<BaseController> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        public async Task<IApiResponse> Create(CreateCurrencyCommand command)
        {
            var response = await Mediator.Send(command);
            return response;
        }

        [HttpPut]
        public async Task<IApiResponse> Update(UpdateCurrencyCommand command)
        {
            var response = await Mediator.Send(command);
            return response;
        }

        [HttpGet("{id}")]
        public async Task<IApiResponse> Get(int id)
        {
            var response = await Mediator.Send(new GetCurrencyQuery(id));
            return response;
        }

        [HttpGet]
        public async Task<IApiResponse> GetAll()
        {
            var response = await Mediator.Send(new GetCurrenciesQuery());
            return response;
        }


        [HttpDelete("{id}")]
        public async Task<IApiResponse> Delete(int id)
        {
            var response = await Mediator.Send(new DeleteCurrencyCommand(id));
            return response;
        }
    }
}
