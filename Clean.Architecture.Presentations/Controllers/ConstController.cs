using Clean.Architecture.Domain.Entities.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.WebApi.Controllers
{
    public class ConstController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<Const> _logger;

        public ConstController(IMediator mediator,ILogger<Const> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

    }
}
