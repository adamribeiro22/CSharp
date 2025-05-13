using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1.cliente
{
    public class Cliente
    {
        public string cpf;
        public string nome;

        public Cliente(string cpf, string nome)
        { 
            this.cpf = cpf; 
            this.nome = nome; 
        }   
    }
}
