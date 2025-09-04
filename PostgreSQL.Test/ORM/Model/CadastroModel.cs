using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL.Test.ORM.Model
{
    public class CadastroModel
    {
        public CadastroModel()
        {
            this.Nome = string.Empty;
            this.Email = string.Empty;
            this.DataCadastro = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
