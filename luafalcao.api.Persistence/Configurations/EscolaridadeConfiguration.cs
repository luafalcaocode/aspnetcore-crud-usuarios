using luafalcao.api.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Persistence.Configurations
{
    public class EscolaridadeConfiguration : IEntityTypeConfiguration<Escolaridade>
    {
        public void Configure(EntityTypeBuilder<Escolaridade> builder)
        {
            builder.HasData(new Escolaridade
            {
                EscolaridadeId = 1,
                Descricao = "Infantil"
            },
            new Escolaridade
            {
                EscolaridadeId = 2,
                Descricao = "Fundamental"
            },
            new Escolaridade
            {
                EscolaridadeId = 3,
                Descricao = "Médio"
            },
            new Escolaridade
            {
                EscolaridadeId = 4,
                Descricao = "Superior"
            });
        }
    }
}
