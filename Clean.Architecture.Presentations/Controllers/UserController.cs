using Clean.Architecture.Application.Dtos;
using Clean.Architecture.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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


        public async Task<ActionResult<UserDto>> GetAllUsers(CancellationToken cancellationToken)
        {
            var query=new GetAllUserQuery();
            var user = await mediator.Send(query, cancellationToken);
            logger.LogInformation("sd");
            return Ok(user);
        }
    }
}
