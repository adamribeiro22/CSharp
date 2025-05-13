using PharmaTech.PharmaAdmin.Domain.Enum;
using System;

namespace PharmaTech.PharmaAdmin.Domain.Model
{
    public class Medicamento
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public TipoMedicamento Tipo { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("O medicamento " + Nome + " do código " + Codigo + " é do tipo " + Tipo + " e custa " + Preco + 0);
        }
    }
}
