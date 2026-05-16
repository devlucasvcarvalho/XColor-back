using Microsoft.AspNetCore.Mvc;
using UserApi.DTO;
using UserApi.DTO.Login;
using UserApi.Models;
using UserApi.Service.UserService;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly IUsuarioInterface _usuarioInterface;
        public LoginController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }



        [HttpPost("register")]
        public async Task<IActionResult> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto)
        {
            var usuario = await _usuarioInterface.RegistrarUsuario(usuarioCriacaoDto);
            return Ok(usuario);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(UsuarioLoginDto usuarioLoginDto)
        {
            var usuario = await _usuarioInterface.Login(usuarioLoginDto);
            return Ok(usuario);
        }

    }
}