using Clean.Architecture.Application.Queries.Const;
using Clean.Architecture.Domain.Entities.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.WebApi.Controllers
{
    public class ConstTypeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ConstTypeController> _logger;

        public ConstTypeController(IMediator mediator, ILogger<ConstTypeController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("GetAllConst")]
        public async Task<ActionResult<List<ConstType>>> GetAllConstType(CancellationToken cancellationToken)
        {
            var query = new GetAllConstTypeQuery();
            var res = _mediator.Send(query, cancellationToken);
            return Ok(res);
        }
        public async Task<ActionResult<ConstType>> GetConstTypeById(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetConstByIdQuery(id);
            var res = await _mediator.Send(query, cancellationToken);
            return Ok(res);
        }
        public async Task<Action<ConstType>> GetConstTypeByKey(string key,CancellationToken cancellationToken)
        {
           var query=new GetConstByKeyQuery(key);
            var res=await _mediator.Send(query,cancellationToken);
            return Ok(res);

        }

    }
}
