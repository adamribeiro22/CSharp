using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2.Classes
{
    public class Pessoa
    {
        public string Nome {  get; set; }
        public Pessoa Conjuge { get; set; }
        public List<Pessoa> Filhos { get; set; }

        public Pessoa (string Nome)
        {
            this.Nome = Nome;
            Filhos = new List<Pessoa>();
        }

        public Pessoa(string nome, Pessoa Nome) : this(nome)
        {
            Nome.AdicionarFilho(this);
        }

        public void AdicionarFilho(Pessoa filho)
        {
            Filhos.Add(filho);
        }

        public void Conjugue(Pessoa conjuge)
        {
            Conjuge = conjuge;
        }

        public void ImprimeArvore(int nivel)
        {
            string grau = new string(' ', nivel * 2);

            if (Conjuge == null)
            {
                Console.WriteLine(grau + "---> " + Nome + " é solteiro(a).");
            }
            else
            {
                Console.WriteLine(grau + "---> " + Nome + " é casado(a) com " +  Conjuge.Nome + " e estes são seus filhos: ");
            }

            foreach (Pessoa filho in Filhos)
            {
                filho.ImprimeArvore(nivel + 1);
            }
        }
    }
}
