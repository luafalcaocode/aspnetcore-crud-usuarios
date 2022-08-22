using luafalcao.api.Facade.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace luafalcao.api.Web.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioFacade usuarioFacade;

        public UsuariosController(IUsuarioFacade usuarioFacade)
        {
            this.usuarioFacade = usuarioFacade;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            var message = await this.usuarioFacade.ObterUsuarios();
            return StatusCode(message.StatusCode, message);
        }

        [HttpGet("{id}", Name = "GetUsuarioPorId")]
        public async Task<IActionResult> GetUsuarioPorId(int id)
        {
            var message = await this.usuarioFacade.ObterUsuario(id);
            return StatusCode(message.StatusCode, message);
        }
    }
}
