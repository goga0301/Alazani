using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Alazani.API.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;
        protected readonly ILogger<BaseController> _logger;

        protected BaseController(IMediator mediator, ILogger<BaseController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

    }
}
