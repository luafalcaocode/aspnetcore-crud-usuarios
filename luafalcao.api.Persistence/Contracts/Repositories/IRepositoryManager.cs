using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Contracts.Repositories
{
    public interface IRepositoryManager
    {
        IUsuarioRepository Usuario { get; }
        
        Task Commit();
    }
}
