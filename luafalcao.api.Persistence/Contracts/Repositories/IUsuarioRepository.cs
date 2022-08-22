using luafalcao.api.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> ObterUsuarios();
        Task<Usuario> ObterUsuario(int usuarioId);
        void Cadastrar(Usuario usuario);
        void Atualizar(Usuario usuario);
        void Remover(Usuario usuario);
    }
}
