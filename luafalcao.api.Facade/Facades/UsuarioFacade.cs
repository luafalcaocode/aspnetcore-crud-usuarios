using AutoMapper;
using luafalcao.api.Domain.Contracts.Services;
using luafalcao.api.Facade.Contracts;
using luafalcao.api.Persistence.DTO;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Utils;
using System;
using System.Collections.Generic;
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
        public async Task<Message> AtualizarUsuario(UsuarioAtualizacaoDto usuario)
        {
            var message = new Message();

            try
            {
                await this.servico.AtualizarUsuario(this.mapper.Map<Usuario>(usuario));

                message.Ok();
            }
            catch(Exception exception)
            {
                if (exception.InnerException == null)
                    message.BadRequest(exception.Message.Split(""));
                else
                    message.Error(exception);
            }

            return message;
        }

        public async Task<Message<UsuarioDto>> CadastrarUsuario(UsuarioCadastroDto usuario)
        {
            var message = new Message<UsuarioDto>();

            try
            {
                var usuarioCadastrado = await this.servico.CadastrarUsuario(this.mapper.Map<Usuario>(usuario));

                message.Created(this.mapper.Map<UsuarioDto>(usuarioCadastrado));
            }
            catch(Exception exception)
            {
                if (exception.InnerException == null)
                    message.BadRequest(exception.Message.Split(""));
                else
                    message.Error(exception);
            }

            return message;
        }

        public Task<Message> ExcluirUsuario(int id)
        {
            throw new NotImplementedException();
        }        
    }
}
