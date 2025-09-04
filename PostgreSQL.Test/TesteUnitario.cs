using Microsoft.EntityFrameworkCore;
using PostgreSQL.Test.ORM;
using PostgreSQL.Test.ORM.Model;

namespace PostgreSQL.Test
{
    public class TesteUnitario
    {
        [Fact]
        public void Teste01()
        {
            using (Context ctx = new Context()) 
            {
                List<CadastroModel> lista = ctx.Cadastro.ToList();
            }
        }

        [Fact]
        public void Teste02()
        {
            using (Context ctx = new Context())
            {
                int id = ctx.Cadastro.Any() ? ctx.Cadastro.ToList().Max(a => a.Id) + 1 : 1;

                DateTime localTime = DateTime.Now;
                DateTime utcTime = localTime.ToUniversalTime();

                CadastroModel model = new CadastroModel()
                {
                    Id = id,
                    Nome = "Eduardo",
                    Email = "eduardo@correa.com",
                    DataCadastro = utcTime
                };

                ctx.Cadastro.Add(model);
                ctx.SaveChanges();
            }
        }
        [Fact]
        public void Teste03()
        {
            using (Context ctx = new Context())
            {
                ctx.Database.ExecuteSqlRaw("TRUNCATE TABLE cadastro");
                ctx.SaveChanges();
            }
        }
    }
}