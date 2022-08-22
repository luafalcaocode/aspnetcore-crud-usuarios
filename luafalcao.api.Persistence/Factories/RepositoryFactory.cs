using luafalcao.api.Persistence.Contexts;
using luafalcao.api.Persistence.Enums;
using luafalcao.api.Persistence.Repositories;

namespace luafalcao.api.Persistence.Factories
{
    public class RepositoryFactory
    {
        public static dynamic Create (RepositoryTypeEnum tipo, ApplicationContext context)
        {
            switch(tipo)
            {
                case RepositoryTypeEnum.Usuario:
                    return new UsuarioRepository(context);
            }

            return null;
        }
    }
}
