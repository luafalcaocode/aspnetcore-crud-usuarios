using luafalcao.api.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Persistence.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasData(new Usuario
            {
                Nome = "José",
                DataNascimento = new DateTime(1990, 08, 10),
                EscolaridadeId = 2,
                Sobrenome = "Silva",
                UsuarioId = 1
            },
            new Usuario
            {
                Nome = "Julia",
                DataNascimento = new DateTime(1975, 02, 22),
                EscolaridadeId = 3,
                Sobrenome = "Silva",
                UsuarioId = 2
            },
           new Usuario
           {
               Nome = "João",
               DataNascimento = new DateTime(1968, 01, 22),
               EscolaridadeId = 4,
               Sobrenome = "Silva",
               UsuarioId = 3
           });
        }
    }
}
