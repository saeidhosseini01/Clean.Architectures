
using Clean.Architecture.Application.Users.Command;
using Clean.Architecture.Application.Users.Dtos;
using Clean.Architecture.Application.Users.Queris;
using Clean.Architecture.Application.Users.Query;
using Clean.Architecture.Domain.Entities.User;
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
        public async Task<ActionResult<UserDto>> GetById(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetUserByIdQuery(id);
            var user=await mediator.Send(query, cancellationToken);
            return Ok(user);
        }
        [HttpGet("AddUser")]
        //public async Task<ActionResult<bool>> AddUser(UserDto userDto,CancellationToken cancellationToken)
        //{
        //    var query = new AddUserCommand(userDto.Id,userDto.Name,userDto.Family,userDto.Age);
        //    var user = await mediator.Send(query, cancellationToken);
        //    return Ok(user);
        //}
        public async Task<ActionResult<bool>> AddUser()
        {
          
            return Ok();
        }
    }
}
