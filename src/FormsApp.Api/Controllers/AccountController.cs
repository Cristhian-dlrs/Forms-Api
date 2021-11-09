using System.Threading.Tasks;
using FormsApp.Application.Contracts.Services;
using FormsApp.Application.DTOs.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormsApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    [Produces("application/json")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserDto>> Register([FromBody] UserLoginDto user)
        {
            await _accountService.RegisterUser(user);
            return Ok();
        }
        
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UserDto>> Login([FromBody] UserLoginDto user)
        {
            var result = await _accountService.Login(user);
            return Ok(result);
        }
    }
}