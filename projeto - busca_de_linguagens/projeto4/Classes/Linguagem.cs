using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto4.Classes
{
    public class Linguagem
    {
        int Ano;
        string Nome;
        string DesenvolvedorChefe;
        string Predecessor;

        internal Linguagem(int Ano, string Nome, string DesenvolvedorChefe, string Predecessor)
        {
            this.Ano = Ano;
            this.Nome = Nome;
            this.DesenvolvedorChefe = DesenvolvedorChefe;
            this.Predecessor = Predecessor;
        }
         public void Imprimir(Linguagens linguagens)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Desenvolvedor chefe: " + DesenvolvedorChefe);
            Console.WriteLine("Predecessores: " + Predecessor);
            Console.WriteLine("---------------------------------------------");
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetAno()
        {
            return Ano;
        }

        public string GetDesenvolvedorChefe()
        {
            return DesenvolvedorChefe;
        }

        public string GetPredecessor()
        {
            return Predecessor;
        }
    }
}
