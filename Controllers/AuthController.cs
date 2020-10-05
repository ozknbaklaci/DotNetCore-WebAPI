using System.Threading.Tasks;
using DotNetCore_WebAPI.Data;
using DotNetCore_WebAPI.Dtos.Character.User;
using DotNetCore_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepository.Register(
                new User { UserName = request.UserName }, request.Password
            );

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}