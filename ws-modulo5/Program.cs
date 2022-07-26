using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_modulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("----------- Cadastro de Conta Bancária -----------");
            Console.WriteLine("\nInforme o número da sua conta bancária");
            Console.Write(">");
            int numeroConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nInforme seu nome completo");
            Console.Write(">");
            string nome = Console.ReadLine();

            Console.WriteLine("Terá depósito inicial" +
                              "\n1 - Sim" +
                              "\n2 - Não");
            Console.Write(">");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("\nEntre com o valor do depósito");
                Console.Write(">");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(numeroConta, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nome);
            }

            Console.WriteLine("\nDados: ");
            Console.WriteLine(conta);

            Console.WriteLine("\nDeseja fazer um depósito?" +
                              "\n 1 - Sim" +
                              "\n 2 - Não");
            Console.Write(">");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("\nInforme o valor do depósito:");
                Console.Write(">");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta.Deposito(valorDeposito);
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine(conta);
            }

            Console.WriteLine("\nDeseja fazer um saque?" +
                              "\n 1 - Sim" +
                              "\n 2 - Não");
            Console.Write(">");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {

                Console.WriteLine("\nInforme o valor do saque:");
                Console.Write(">");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Saque(valorSaque);

                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine(conta);
            }

            Console.WriteLine("\nDeseja modificar seu nome?" +
                              "\n1 - Sim" +
                              "\n2 - Não");
            Console.Write(">");

            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("\nEntre com o seu nome");
                Console.Write(">");
                conta.NomeTitular = Console.ReadLine();
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine(conta);
            }
            

        }

        static string Produto()
        {
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(nome, preco);

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            return p.ToString();
        }
    }
}

