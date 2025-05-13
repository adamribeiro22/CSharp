using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace projeto4.Classes
{
    public class Linguagens
    {
        private List<Linguagem> linguagens = new List<Linguagem>();

        public void AdicionarLinguagem(Linguagem l)
        {
            linguagens.Add(l);
        }

        public void RemoverLinguagem(Linguagem l)
        {
            if (l != null && linguagens.Contains(l))
            {
                linguagens.Remove(l);
                Console.WriteLine("Linguagem removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Linguagem não encontrada");
            }
        }

        public Linguagem BuscarLinguagemPorNome(string Nome)
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                Console.WriteLine("Favor inserir nome"); 
                return null;
            }
            return linguagens.FirstOrDefault(l => l.GetNome().StartsWith(Nome, StringComparison.OrdinalIgnoreCase));
        }

        public Linguagem BuscarPorAno(int Ano)
        {
            return linguagens.FirstOrDefault(l => l.GetAno().Equals(Ano));
        }

        public Linguagem BuscarPorDesenvolvedorChefe(string DesenvolvedorChefe)
        {
            if (string.IsNullOrWhiteSpace(DesenvolvedorChefe))
            {
                Console.WriteLine("Favor inserir nome");
                return null;
            }
            return linguagens.FirstOrDefault(l => l.GetDesenvolvedorChefe().Contains(DesenvolvedorChefe));
        }

        public Linguagem BuscarPorPredecessores(string Predecessor)
        {
            if (string.IsNullOrWhiteSpace(Predecessor))
            {
                Console.WriteLine("Favor inserir nome");
                return null;
            }
            return linguagens.FirstOrDefault(l => l.GetPredecessor().Contains(Predecessor));
        }
    }
}
