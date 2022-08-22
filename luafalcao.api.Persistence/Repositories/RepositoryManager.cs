using luafalcao.api.Persistence.Contexts;
using luafalcao.api.Persistence.Contracts.Repositories;
using luafalcao.api.Persistence.Enums;
using luafalcao.api.Persistence.Factories;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private IUsuarioRepository usuario;
        private ApplicationContext contexto; 

        public RepositoryManager(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public IUsuarioRepository Usuario
        {
            get
            {
                if (this.usuario == null)
                {
                    this.usuario = RepositoryFactory.Create(RepositoryTypeEnum.Usuario, contexto);
                }

                return usuario;
            }
        }

        public async Task Commit()
        {
            await contexto.SaveChangesAsync();
        }
    }
}
