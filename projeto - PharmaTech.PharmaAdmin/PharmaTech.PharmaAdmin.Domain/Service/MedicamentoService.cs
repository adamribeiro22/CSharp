using PharmaTech.PharmaAdmin.Domain.Enum;
using PharmaTech.PharmaAdmin.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmaTech.PharmaAdmin.Domain.Service
{
    public class MedicamentoService
    {
        private List<Medicamento> medicamentos = new List<Medicamento>();
        private long novoCodigo = 1;

        public long CadastrarMedicamento(string nome, double preco, TipoMedicamento tipo)
        {
            if (medicamentos.Any(m => m.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Já existe um medicamento com nome " + nome);
                return 0;
            }

            var medicamento = new Medicamento
            {
                Codigo = novoCodigo++,
                Nome = nome,
                Preco = preco,
                Tipo = tipo
            };

            medicamentos.Add(medicamento);
            return medicamento.Codigo;
        }

        public void AlterarPreco(long codigo, double preco)
        {
            var medicamento = medicamentos.FirstOrDefault(m => m.Codigo == codigo);
            if (medicamento != null)
            {
                medicamento.Preco = preco;
            }
            else
            {
                Console.WriteLine("Medicamento não encontrado");
                return;
            }
        }

        public void ImprimirMedicamento(long codigo)
        {
            var medicamento = medicamentos.FirstOrDefault(m => m.Codigo == codigo);
            if (medicamento != null)
            {
                medicamento.Imprimir();
            }
            else
            {
                Console.WriteLine("Medicamento não encontrado");
            }
        }

        public long BuscarCodigoPorNome(string nome)
        {
            var medicamento = medicamentos.FirstOrDefault(m => m.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            return medicamento?.Codigo ?? 0;
        }

        public void ImprimirMedicamentoPorTipo(TipoMedicamento tipo)
        {
            var resultado = medicamentos.Where(m => m.Tipo == tipo).ToList();
            if (resultado.Any())
            {
                foreach (var medicamento in resultado)
                {
                    medicamento.Imprimir();
                }
            }
            else
            {
                Console.WriteLine("Nenhum medicamento do tipo " + tipo + " encontrado");
            }
        }
    }
}
