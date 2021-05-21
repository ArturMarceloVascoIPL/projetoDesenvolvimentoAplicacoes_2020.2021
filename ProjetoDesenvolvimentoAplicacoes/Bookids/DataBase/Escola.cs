using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Escola
    {
        public Escola(string nome, string morada, string localidade, string codPostal, int telefone, string email)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.Localidade = localidade;
            this.CodPostal = codPostal;
            this.Telefone = telefone;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"{Nome}, {Localidade}, {Email}";
        }
    }
}
