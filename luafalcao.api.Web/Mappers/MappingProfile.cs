using AutoMapper;
using luafalcao.api.Persistence.DTO;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Utils;
using System.Linq.Expressions;

namespace luafalcao.api.Web.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            MapUsuario();

            CreateMap(typeof(Message<>), typeof(Message<>));
            CreateMap(typeof(Expression<>), typeof(Expression<>));
        }       

        public void MapUsuario()
        {
            CreateMap<UsuarioDto, Usuario>();
            CreateMap<Usuario, UsuarioDto>();

            CreateMap<UsuarioCadastroDto, Usuario>();
            CreateMap<UsuarioAtualizacaoDto, Usuario>()
                .ForMember(c => c.UsuarioId, option => option.MapFrom(x => x.Id));

            CreateMap<EscolaridadeCadastroDto, Escolaridade>();

            CreateMap<Escolaridade, EscolaridadeDto>();
            CreateMap<EscolaridadeDto, Escolaridade>();
        }
    }
}
