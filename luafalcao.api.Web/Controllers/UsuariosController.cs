using luafalcao.api.Facade.Contracts;
using luafalcao.api.Persistence.DTO;
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

        [HttpPost]
        public async Task<IActionResult> PostUsuarios(UsuarioCadastroDto usuarioDto)
        {
            var message = await this.usuarioFacade.CadastrarUsuario(usuarioDto);

            return CreatedAtRoute("GetUsuarioPorId", new { Id = message.Data.UsuarioId }, message.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsuarios(UsuarioAtualizacaoDto usuario)
        {
            var message = await this.usuarioFacade.AtualizarUsuario(usuario);

            return StatusCode(message.StatusCode, message);
        }
    }
}
