using luafalcao.api.Domain.Contracts.Services;
using luafalcao.api.Domain.Validations;
using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IRepositoryManager repositorio;

        public UsuarioService(IRepositoryManager repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<Usuario> ObterUsuario(int id)
        {
            return await this.repositorio.Usuario.ObterUsuario(id);
        }

        public async Task<IEnumerable<Usuario>> ObterUsuarios()
        {
            return await this.repositorio.Usuario.ObterUsuarios();
        }

        public async Task RemoverUsuario(Usuario usuario)
        {
            this.repositorio.Usuario.Remover(usuario);
            await this.repositorio.Commit();
        }

        public async Task AtualizarUsuario(Usuario usuario)
        {
            var validacoes = UsuarioValidationsSingleton.GetInstance().Validar(usuario);
          
            if (validacoes.Any())
            {
                throw new Exception(string.Join(" ", validacoes));
            }

            this.repositorio.Usuario.Atualizar(usuario);

            await this.repositorio.Commit();
        }

        public async Task<Usuario> CadastrarUsuario(Usuario usuario)
        {
            var validacoes = UsuarioValidationsSingleton.GetInstance().Validar(usuario);

            if (validacoes.Any())
            {
                throw new Exception(string.Join(" ", validacoes));
            }
            
            this.repositorio.Usuario.Cadastrar(usuario);

            await this.repositorio.Commit();

            return usuario;
        }
    }
}
