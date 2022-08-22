using luafalcao.api.Persistence.Contexts;
using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Usuario>> ObterUsuarios()
        {
            return await FindAll()
                .ToListAsync();
        }

        public async Task<Usuario> ObterUsuario(int usuarioId)
        {
            return await FindByCondition(filtro => filtro.UsuarioId.Equals(usuarioId))
                .FirstOrDefaultAsync();
        }

        public void Cadastrar(Usuario usuario)
        {
            Create(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            Update(usuario);
        }

        public void Remover(Usuario usuario)
        {
            Delete(usuario);
        }
    }
}
