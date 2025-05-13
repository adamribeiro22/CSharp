using PharmaTech.PharmaAdmin.Domain.Enum;
using PharmaTech.PharmaAdmin.Domain.Service;
using System;

namespace PharmaTech.PharmaAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new MedicamentoService();

            long codigo1 = service.CadastrarMedicamento("Paracetamol", 7.90, TipoMedicamento.Generico);
            long codigo2 = service.CadastrarMedicamento("Aspirina", 19.90, TipoMedicamento.Original);
            long codigo3 = service.CadastrarMedicamento("Tylenol", 9.90, TipoMedicamento.Similar);
            long codigo4 = service.CadastrarMedicamento("Alprazolam", 14.90, TipoMedicamento.Generico);
            long codigo5 = service.CadastrarMedicamento("Rivotril", 11.90, TipoMedicamento.Original);
            long codigo6 = service.CadastrarMedicamento("Torsilax", 8.90, TipoMedicamento.Similar);

            service.ImprimirMedicamento(codigo2);
            service.ImprimirMedicamento(codigo4);
            service.ImprimirMedicamento(codigo5);

            Console.WriteLine("\nAlterando preço da Aspirina: ");
            service.AlterarPreco(codigo2, 12.90);
            service.ImprimirMedicamento(codigo2);

            Console.WriteLine("\nBuscando o código do medicamento por nome: ");
            Console.WriteLine("Código do Torsilax: " + service.BuscarCodigoPorNome("Torsilax"));

            Console.WriteLine("\nPesquisando por tipo: ");
            service.ImprimirMedicamentoPorTipo(TipoMedicamento.Generico);
        }
    }
}
