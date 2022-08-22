using luafalcao.api.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Contracts.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ObterUsuarios();
        Task<Usuario> ObterUsuario(int id);
        Task CadastrarUsuario(Usuario usuario);
        Task AtualizarUsuario(Usuario usuario);
        Task RemoverUsuario(Usuario usuario);
    }
}
