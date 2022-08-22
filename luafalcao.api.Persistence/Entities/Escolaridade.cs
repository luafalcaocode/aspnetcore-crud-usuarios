using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace luafalcao.api.Persistence.Entities
{
    public class Escolaridade
    {
        [Column("Id")]
        public int EscolaridadeId { get; set; }
        public string Descricao { get; set; }
    }
}
