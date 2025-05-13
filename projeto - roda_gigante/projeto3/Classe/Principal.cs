using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projeto3.Classe
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;

        }
    }
    class Adulto : Pessoa
    {
        public Adulto(string Nome, int Idade) : base(Nome, Idade)
        {

        }
    }

    class Crianca : Pessoa
    {
        public Adulto Responsavel {get; private set;}

        public Crianca(string Nome, int Idade, Adulto Responsavel = null) : base(Nome, Idade)
        {
            this.Responsavel = Responsavel;
        }
    }
    class Gondola
    {
        public int Numero { get; set;}
        public List<Pessoa> Passageiros { get; private set;}

        public Gondola (int Numero)
        {
            this.Numero = Numero;
            Passageiros = new List<Pessoa>();
        }

        public bool Vazio()
        {
            return Passageiros.Count == 0;
        }

        public void Embarque(params Pessoa[] pessoas)
        {
            Passageiros.AddRange(pessoas);
        }

        public override string ToString()
        {
            if (Vazio())
            {
                return Numero + " (vazia)";
            }

            string resposta = Numero + " ";

            List<string> passageiros = new List<string>();
            foreach (var passageiro in Passageiros)
            {
                passageiros.Add(passageiro.Nome);
            }

            resposta += string.Join(" / Responsável: ", passageiros);
            return resposta;
        }
    }

    class RodaGigante
    {
        private List<Gondola> Gondolas;

        public RodaGigante()
        {
            Gondolas = new List<Gondola>();
            for (int i = 1; i <= 18; i++)
            {
                Gondolas.Add(new Gondola(i));
            }
        }

        public void Embarque(int NumeroGondola, params Pessoa[] pessoas)
        {
            if (NumeroGondola < 1 || NumeroGondola > 18)
            {
                Console.WriteLine("Número de gôndola inválido");
                return;
            }

            var gondola = Gondolas[NumeroGondola  - 1];

            foreach (var pessoa in pessoas)
            {
                if (pessoa is Crianca crianca && crianca.Idade < 12 && !pessoas.Contains(crianca.Responsavel))
                {
                    Console.WriteLine("ERRO: " + crianca.Nome + " tem menos de 12 anos e não está acompanhado(a) de um responsável");
                    Console.WriteLine(" ");
                    return;
                }
            }

            gondola.Embarque(pessoas);
        }

        public void Status()
        {
            Console.WriteLine("~~~~GÔNDOLAS~~~~");
            Console.WriteLine("----------------");
            foreach (var gondola in Gondolas)
            {
                Console.WriteLine(gondola);
            }
        }
    }

}

