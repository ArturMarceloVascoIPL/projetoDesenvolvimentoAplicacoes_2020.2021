using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Animador
    { 

        public Animador(string Nome,string Morada,string Localidade,string CodPostal,int Telefone,int Telemovel,string Email,string Especialidade)
        {
            this.Nome = Nome;
            this.Morada = Morada;
            this.Localidade = Localidade;
            this.CodPostal = CodPostal;
            this.Telefone = Telefone;
            this.Telemovel = Telemovel;
            this.Email = Email;
            this.Especialidade = Especialidade;
        }
        public override string ToString()
        {
            return $"{Nome} - {Especialidade}";
        }

    }
}
