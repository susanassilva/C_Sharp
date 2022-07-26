using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_modulo4
{
    internal class Program
    {
        static void Main()
        {
            //Triangulo();
            //EntradaNomes();
            //CalculadoraSalarios();
            //EstoqueProdutos();
            //CalcularRetangulo();
            //CalculaEsfera();
        }

        public static void CalculaEsfera()
        {
            Console.WriteLine("Digite o valor do raio: ");
            var raio = double.Parse(Console.ReadLine());

            double circunferencia = Esfera.Circunferencia(raio);
            double volume = Esfera.Volume(raio);


            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Esfera.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void CalcularRetangulo()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var area = retangulo.CalculaArea();
            var perimetro = retangulo.CalculaPerimetro();
            var diagonal = retangulo.CalculaDiagonal();
            
            Console.WriteLine($"Área = {area :0.00}");

            Console.WriteLine($"Perímetro = {perimetro:0.00}");
            Console.WriteLine($"Diagonal = {diagonal:0.00}");

        }

        public static void EstoqueProdutos()
        {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            produto.QuantiaEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + produto);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            var auxiliar = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(auxiliar);

            Console.WriteLine("Dados atualizados: " + produto);


            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            auxiliar = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(auxiliar);

            Console.WriteLine("Dados atualizados: " + produto);

        }

        public static void CalculadoraSalarios()
        {
            //exercicio2
            Funcionarios funcionario1, funcionario2;

            funcionario1 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            funcionario1.Salario= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            funcionario2 = new Funcionarios();
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var mediaSalarial = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = ${mediaSalarial : 0.00}");

        }

        public static void EntradaNomes()
        {
            //exercicio 1 
            DadosPessoais usuario1, usuario2;

            usuario1 = new DadosPessoais();
            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Entre com seu nome: ");
            usuario1.Nome = Console.ReadLine();

            Console.Write("Entre com sua idade: ");
            usuario1.Idade = int.Parse(Console.ReadLine());

            usuario2 = new DadosPessoais();
            Console.WriteLine("Dados da segunda pessoa: ");

            Console.Write("Digite seu nome: ");
            usuario2.Nome = Console.ReadLine();
            
            Console.Write("Entre com sua idade: ");
            usuario2.Idade = int.Parse(Console.ReadLine());

            var resultado = usuario1.Idade > usuario2.Idade
                ? $"A(o) {usuario1.Nome} é mais velha(o)"
                : $"A(o) {usuario2.Nome} é mais velha(o)";

            Console.WriteLine(resultado);

        }

        public static void Triangulo()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            

            Console.WriteLine("X: " + x.CalcularArea());

            

            Console.WriteLine("Y: " +  y.CalcularArea());
        }
    }
}
