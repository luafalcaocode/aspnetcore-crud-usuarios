using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace luafalcao.api.Persistence.Entities
{
    public class Usuario
    {
        [Column("Id")]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int? HistoricoEscolarId { get; set; }


        [ForeignKey(nameof(Escolaridade))]
        public int? EscolaridadeId { get; set; }

        public Escolaridade Escolaridade { get; set; }
    }
}
