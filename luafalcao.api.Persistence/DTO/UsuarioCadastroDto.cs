using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Persistence.DTO
{
    public class UsuarioCadastroDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public int? HistoricoEscolarId { get; set; }
        public int? EscolaridadeId { get; set; }
    }
}
