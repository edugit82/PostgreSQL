using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSQL.Test.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL.Test.ORM.Map
{
    internal class CadastroMap
    {
        public CadastroMap(ref ModelBuilder modelBuilder)
        {
            Action<EntityTypeBuilder<CadastroModel>> map = config =>
            {
                config.Property(p => p.Id).HasColumnName("id").ValueGeneratedNever();
                config.Property(p => p.Nome).HasColumnName("nome");
                config.Property(p => p.Email).HasColumnName("email");
                config.Property(p => p.DataCadastro).HasColumnName("datacadastro");

                config.ToTable("cadastro");
            };

            modelBuilder.Entity(map);
            modelBuilder.Entity<CadastroModel>().HasKey(k => k.Id);
        }
    }
}
