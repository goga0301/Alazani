using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alazani.API.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator Mediator;
        protected readonly ILogger<BaseController> Logger;

        protected BaseController(IMediator mediator, ILogger<BaseController> logger)
        {
            Mediator = mediator;
            Logger = logger;
        }

    }
}
