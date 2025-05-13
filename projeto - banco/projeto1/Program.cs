using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto1.cliente;
using projeto1.conta;

namespace projeto1
{
    static class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Conta> contas = new List<Conta>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------");
                Console.WriteLine("BANCO EUROPA");
                Console.WriteLine("------------");
                Console.WriteLine("Selecione a opção que deseja: ");
                Console.WriteLine("-Opção 1: Cadastrar Cliente");
                Console.WriteLine("-Opção 2: Depositar");
                Console.WriteLine("-Opção 3: Sacar");
                Console.WriteLine("-Opção 4: Ver saldo");
                Console.WriteLine("-Opção 5: Transferir");
                Console.WriteLine("-Opção 6: Sair");
                Console.WriteLine("-------------");
                Console.Write("Selecione a opção que deseja: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        cadastroCliente();
                        break;

                    case 2:
                        Deposito();
                        break;

                    case 3:
                        Saque();
                        break;

                    case 4:
                        Extrato();
                        break;

                    case 5:
                        Transferencia();
                        break;

                    case 6:
                        Console.WriteLine("Saindo...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente");
                        break;
                }
            }
        }

        private static Conta buscarConta()
        {
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            foreach (Conta conta in contas)
            {
                if (conta.numero_conta == numero)
                {
                    return conta;
                }
            }

            Console.WriteLine("Conta não encontrada, tente novamente");
            return null;
        }

        static void cadastroCliente()
        {
            Console.Write("Digite o CPF do titular: ");
            string cpf = Console.ReadLine();
            foreach (Cliente cliente in clientes)
            {
                if (cliente == null)
                {
                    Console.WriteLine("CPF inválido, tente novamente.");
                    return;
                }
                if (cliente.cpf == cpf)
                {
                    Console.WriteLine("CPF já existente, digite um outro CPF");
                    return;
                }
            }
            Console.Write("Digite o nome do titular: ");
            string nome = Console.ReadLine();

            Cliente novoCliente = new Cliente(cpf, nome);
            clientes.Add(novoCliente);

            Conta novaConta = new Conta(novoCliente);
            contas.Add(novaConta);
            Console.WriteLine("Conta cadastrada com sucesso! O número da sua conta é " + novaConta.numero_conta);
        }
        private static void Deposito()
        {
            Conta conta = buscarConta();
            if (conta != null)
            {
                Console.Write("Digite o valor para depósito: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Deposito(valor);
            }
        }

        private static void Saque()
        {
            Conta conta = buscarConta();
            if (conta != null)
            {
                Console.Write("Digite o valor que deseja sacar: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Saque(valor);
            }
        }

        private static void Extrato()
        {
            Conta conta = buscarConta();
            if (conta != null)
            {
                conta.Extrato();
            }
        }

        private static void Transferencia()
        {
            Console.WriteLine("Digite a conta de origem: ");
            Conta contaOrigem = buscarConta();
            if (contaOrigem != null)
            {
                Console.WriteLine("Digite a conta de destino: ");
                Conta contaDestino = buscarConta();
                if (contaDestino != null)
                {
                    Console.WriteLine("Digite o valor para transferência: ");
                    double valor = double.Parse(Console.ReadLine());
                    contaOrigem.Transferencia(contaDestino, valor);
                }
            }
        }
    }
}
