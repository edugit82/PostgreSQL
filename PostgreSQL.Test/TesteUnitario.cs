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
    }
}