using Microsoft.EntityFrameworkCore;
using Npgsql;
using PostgreSQL.Test.ORM.Map;
using PostgreSQL.Test.ORM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL.Test.ORM
{
    internal class Context : DbContext
    {
        public Context()
        {
            if (this.Database.EnsureCreated())
                this.Database.Migrate();
        }
        public DbSet<CadastroModel> Cadastro { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=20.121.53.209;Port=5432;Database=postgres_db;Username=edupostgresuser;Password=cK5#aM9@");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CadastroMap(ref modelBuilder);
        }
    }
}