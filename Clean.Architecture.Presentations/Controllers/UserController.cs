using Clean.Architecture.Application.Dtos.User;
using Clean.Architecture.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Clean.Architecture.Presentations.Controllers
{




    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<UserController> logger;
        
        public UserController(IMediator mediator,ILogger<UserController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<List<UserDto>>> GetAllUsers(CancellationToken cancellationToken)
        {
            var query=new GetAllUserQuery();
            var user = await mediator.Send(query, cancellationToken);
            logger.LogInformation("sd");
            return Ok(user);
        }
        [HttpGet("GetById")]
        public async Task<ActionResult<UserDto>> GetById( CancellationToken cancellationToken)
        {
            var querq = new GetUserByIdQuery("1");
            var user=await mediator.Send(querq, cancellationToken);
            return Ok(user);
        }
     }
}
