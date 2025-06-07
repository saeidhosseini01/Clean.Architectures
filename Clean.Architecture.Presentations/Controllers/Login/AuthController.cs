using AutoMapper;
using Clean.Architecture.Application.UseCases.Logins.Commands;
using Clean.Architecture.Application.UseCases.Logins.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.WebApi.Controllers.Login
{
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<string> _mapper;

        public AuthController(IMediator mediator,ILogger<string> mapper )
        {
            _mediator = mediator;
           _mapper = mapper;
        }


        public async Task<IActionResult> Login([FromBody] RequestLogin request )
        {
            try
            {
                var command = new LoginCommand(request.Username, request.Password);
                var Token = await _mediator.Send(command);
                return Ok(Token);
            }
            catch (UnauthorizedAccessException)
            {

                return Unauthorized();
            }
        }
    }
}
