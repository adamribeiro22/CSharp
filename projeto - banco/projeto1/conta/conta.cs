using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto1.cliente;

namespace projeto1.conta
{
    public class Conta
    {
        public int numero_conta;
        public double saldo;
        public Cliente Cliente;

        static int numero_conta_geral = 101;

        public Conta(Cliente cliente)
        {
            this.numero_conta = numero_conta_geral++;
            saldo = 0;
            this.Cliente = cliente;
        }

        public void Deposito(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                saldo += valor;
                Console.WriteLine("Depósito de R$" + valor + " feito com sucesso!");
            }
        }

        public void Saque(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Saque de R$" + valor + " feito com sucesso!");
            }
            else
            {
                if (valor > saldo)
                {
                    Console.WriteLine("Saldo insuficiente para saque.");
                }
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido");
                }
            }
            
        }

        public void Extrato()
        {
            Console.WriteLine("Valor atual: " + saldo);
        }

        public void Transferencia(Conta contaDestino, double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                contaDestino.Deposito(valor);
                Console.WriteLine("Transferência de R$" + valor + " para " + contaDestino.numero_conta + " feito com sucesso!");
            }
            else
            {
                if (valor > saldo)
                {
                    Console.WriteLine("Saldo insuficiente para transferência");
                }
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido");
                }
            }
        }
    }
}
