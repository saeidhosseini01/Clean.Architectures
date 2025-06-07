using Clean.Architecture.Application.Dtos.Base;
using Clean.Architecture.Application.UseCases.Consts.Queris;
using Clean.Architecture.Domain.Entities.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ConstController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<Const> _logger;

        public ConstController(IMediator mediator,ILogger<Const> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet("GetAllConst")]
        public  async Task<ActionResult<List<Const>>> GetAllConst(CancellationToken cancellationToken)
        {
            var query=new GetAllConstQuery();
            var res= await _mediator.Send(query,cancellationToken);
            return Ok(res);
        }
        [HttpGet("GetConstById")]
        public async Task<ActionResult<Const>> GetConstById(Guid id, CancellationToken cancellationToken)
        {
            var query = GetConstById(id, cancellationToken);
            var res=await _mediator.Send(query, cancellationToken);
            return Ok(res);
        }
        [HttpGet("GetConstByKey")]
        public async Task<ActionResult<List<TValue<string>>>> GetConstByKeys(string key,CancellationToken cancellationToken)

        {
            var guery= new GetConstByKeyQuery(key);
            var res= await  _mediator.Send(guery, cancellationToken);
            return Ok(res);
        }
    }
}
