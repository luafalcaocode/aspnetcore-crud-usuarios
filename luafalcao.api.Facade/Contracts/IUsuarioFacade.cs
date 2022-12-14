using luafalcao.api.Persistence.DTO;
using luafalcao.api.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Facade.Contracts
{
    public interface IUsuarioFacade
    {
        Task<Message<IEnumerable<UsuarioDto>>> ObterUsuarios();
        Task<Message<UsuarioDto>> ObterUsuario(int id);
        Task<Message<UsuarioDto>> CadastrarUsuario(UsuarioCadastroDto usuario);
        Task<Message> AtualizarUsuario(UsuarioAtualizacaoDto usuario);
        Task<Message> ExcluirUsuario(int id);
    }
}
