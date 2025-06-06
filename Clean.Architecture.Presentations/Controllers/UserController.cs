﻿
using Clean.Architecture.Application.Users.Dtos;
using Clean.Architecture.Application.Users.Queris;
using Clean.Architecture.Application.Users.Query;
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
            var query = new GetUserByIdQuery(new Guid());
            var user=await mediator.Send(query, cancellationToken);
            return Ok(user);
        }
     }
}
