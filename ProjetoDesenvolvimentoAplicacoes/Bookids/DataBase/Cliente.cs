using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookids
{
    partial class Cliente
    {
        public Cliente(string nome, string morada, string localidade, string codPostal, int telemovel, int telefone, string email, int numCartao)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.Localidade = localidade;
            this.CodPostal = codPostal;
            this.Telemovel = telemovel;
            this.Telefone = telefone;
            this.Email = email;
            this.NumCartao = numCartao;
        }

        public override string ToString()
        {
            return $"{Nome}, {Localidade}, {Email}";
        }
    }
}
