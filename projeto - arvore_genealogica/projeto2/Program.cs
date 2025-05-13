using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto2.Classes;

namespace projeto2
{
    class TestaArvore
    {
        static void Main()
        {
            Pessoa Lily = new Pessoa("Lily");
            Lily.Conjugue(new Pessoa("Wilhelm"));

            // Patriarcas
            Pessoa Opa = new Pessoa("Opa", Lily);
            Opa.Conjugue(new Pessoa("Oma"));

            // Filhos de Oma e Opa
            Pessoa Reinhold = new Pessoa("Reinhold", Opa);
            Pessoa Wilma = new Pessoa("Wilma", Opa);
            Pessoa Sigrid = new Pessoa("Sigrid", Opa);

            // Filhos e esposa de Reinhold
            Reinhold.Conjugue(new Pessoa("Sonia"));
            Pessoa Christian = new Pessoa("Christian", Reinhold);
            Pessoa Gabrielle = new Pessoa("Gabrielle", Reinhold);
            Pessoa Sabine = new Pessoa("Sabine", Reinhold);

            // Filhos e marido de Wilma
            Wilma.Conjugue(new Pessoa("Rodolfo"));
            Pessoa Ricardo = new Pessoa("Ricardo", Wilma);
            Pessoa Rodrigo = new Pessoa("Rodrigo", Wilma);
        
            // Ricardo e esposa
            Ricardo.Conjugue(new Pessoa("Debora"));

            // Filhos e esposa de Christian
            Christian.Conjugue(new Pessoa("Mônica"));
            Pessoa Oscar = new Pessoa("Oscar", Christian);
            Pessoa Lorena = new Pessoa("Lorena", Christian);

            // Filhos e marido de Sigrid
            Sigrid.Conjugue(new Pessoa("Peter"));
            Pessoa Martin = new Pessoa("Martin", Sigrid);
            Pessoa Thomas = new Pessoa("Thomas", Sigrid);
            Pessoa Claudia = new Pessoa("Claudia", Sigrid);

            // Martin e esposa
            Martin.Conjugue(new Pessoa("Carla"));
            Martin.AdicionarFilho(new Pessoa("Nicolas"));

            // Impressão da árvore genealógica
            Lily.ImprimeArvore(0);
        }
    }
}
