using AutoMapper;
using luafalcao.api.Domain.Contracts.Services;
using luafalcao.api.Facade.Contracts;
using luafalcao.api.Persistence.DTO;
using luafalcao.api.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Facade.Facades
{
    public class UsuarioFacade : IUsuarioFacade
    {
        private IUsuarioService servico;
        private IMapper mapper;

        public UsuarioFacade(IUsuarioService service, IMapper mapper)
        {
            this.servico = service;
            this.mapper = mapper;
        }

        public async Task<Message<UsuarioDto>> ObterUsuario(int id)
        {
            var message = new Message<UsuarioDto>();

            try
            {
                var usuario = this.mapper.Map<UsuarioDto>(await this.servico.ObterUsuario(id));
                if (usuario == null)
                {
                    message.NotFound();

                    return message;
                }

                message.Ok(usuario);
            }
            catch(Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }

        public async Task<Message<IEnumerable<UsuarioDto>>> ObterUsuarios()
        {
            var message = new Message<IEnumerable<UsuarioDto>>();

            try
            {
                var usuarios = this.mapper.Map<IEnumerable<UsuarioDto>>(await this.servico.ObterUsuarios());
                if (usuarios == null)
                {
                    message.NotFound();

                    return message;
                }

                message.Ok(usuarios);
            }
            catch (Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }
        public Task<Message> AtualizarUsuario(UsuarioDto usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Message> CadastrarUsuario(UsuarioCadastroDto usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Message> ExcluirUsuario(int id)
        {
            throw new NotImplementedException();
        }        
    }
}
