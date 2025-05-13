using System;
using System.Collections.Generic;
using System.Text;
using projeto3.Classe;

namespace projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            RodaGigante roda = new RodaGigante();
            Adulto paulo = new Adulto("Paulo", 42);

            Crianca joao = new Crianca("João", 5, paulo);
            Crianca maria = new Crianca("Maria", 12, paulo);
            Crianca pedro = new Crianca("Pedro", 13);
            Crianca henrique = new Crianca("Henrique", 10);

            roda.Embarque(2, joao, maria);
            roda.Embarque(2, joao, paulo);
            roda.Embarque(3, maria);
            roda.Embarque(13, pedro);
            roda.Embarque(16, henrique);
            roda.Status();
        }
    }
}
