using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using projeto4.Classes;

namespace projeto4
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Linguagens linguagens = new Linguagens();

            linguagens.AdicionarLinguagem(new Linguagem(1990, "AMOS BASIC", "François Lionet, Constantin Sotiropoulos", "STO BASIC"));
            linguagens.AdicionarLinguagem(new Linguagem(1991, "Visual Basic", "Alan Cooper", "QuickBasic"));
            linguagens.AdicionarLinguagem(new Linguagem(1995, "Ruby", "Yukihiro Matsumoto", "Smalltalk; Perl"));
            linguagens.AdicionarLinguagem(new Linguagem(2009, "Go", "Google", "C; Oberon; Limbo; Smalltalk"));

            while (true)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("BUSCA DE LINGUAGENS");
                Console.WriteLine("---------------------");
                Console.WriteLine("Opção 1: Adicionar linguagem");
                Console.WriteLine("Opção 2: Remover linguagem pelo nome");
                Console.WriteLine("Opção 3: Buscar linguagem por nome");
                Console.WriteLine("Opção 4: Buscar linguagem por ano");
                Console.WriteLine("Opção 5: Buscar linguagem por desenvolvedor chefe");
                Console.WriteLine("Opção 6: Buscar linguagem por predecesor");
                Console.WriteLine("Opção 7: Sair");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o ano da linguagem");
                        int ano = int.Parse(Console.ReadLine());
                        if (ano == null)
                        {
                            Console.WriteLine("Inserir ano válido");
                            return;
                        }

                        Console.WriteLine("Digite o nome da linguagem");
                        string nome = Console.ReadLine();
                        if (nome == null)
                        {
                            Console.WriteLine("ERRO: necessário inserir nome");
                            return;
                        }

                        Console.WriteLine("Digite o desenvolvedor chefe da linguagem");
                        string desenvolvedorChefe = Console.ReadLine();
                        if (desenvolvedorChefe == null)
                        {
                            Console.WriteLine("ERRO: necessário inserir nome");
                            return;
                        }

                        Console.WriteLine("Digite o predecessor da linguagem");
                        string predecessor = Console.ReadLine();
                        if (predecessor == null)
                        {
                            Console.WriteLine("ERRO: necessário inserir predecessor");
                            return;
                        }

                        linguagens.AdicionarLinguagem(new Linguagem(ano, nome, desenvolvedorChefe, predecessor));
                        Console.WriteLine("Linguagem adicionada com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome da linguagem que deseja remover: ");
                        string nomeRemover = Console.ReadLine();
                        if (string.IsNullOrEmpty(nomeRemover))
                        {
                            Console.WriteLine("Favor inserir nome");
                        }

                        Linguagem linguagemRemover = linguagens.BuscarLinguagemPorNome(nomeRemover);

                        if (linguagemRemover != null)
                        {
                            linguagens.RemoverLinguagem(linguagemRemover);
                        }
                        else
                        {
                            Console.WriteLine("Linguagem não encontrada");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Digite o nome da linguagem: ");
                        Linguagem linguagemNome = linguagens.BuscarLinguagemPorNome(Console.ReadLine());
                        linguagemNome?.Imprimir(linguagens);
                        break;

                    case 4:
                        Console.Write("Digite o ano: ");
                        Linguagem linguagemAno = linguagens.BuscarPorAno(int.Parse(Console.ReadLine()));
                        linguagemAno?.Imprimir(linguagens);
                        break;

                    case 5:
                        Console.WriteLine("Digite o nome do desenvolvedor chefe: ");
                        Linguagem linguagemDev = linguagens.BuscarPorDesenvolvedorChefe(Console.ReadLine());
                        linguagemDev?.Imprimir(linguagens);
                        break;

                    case 6:
                        Console.WriteLine("Digite o nome o predecessor: ");
                        Linguagem linguagemPredecessor = linguagens.BuscarPorPredecessores(Console.ReadLine());
                        linguagemPredecessor?.Imprimir(linguagens);
                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Opção inválida, tente novamete");
                        break;

                }
            }
        }
    }
}
