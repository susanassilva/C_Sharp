using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_exercicios_modulo3
{
    public class exercicio1
    {
        public exercicio1()
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int numeroQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vetorObjetos = Console.ReadLine().Split(' ');

            string ultimoNome = vetorObjetos[0];
            int idade = int.Parse(vetorObjetos[1]);
            double altura = double.Parse(vetorObjetos[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
