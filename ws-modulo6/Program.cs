using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_modulo6
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            */
            /* double vect = UsandoVetor();
             Console.WriteLine(vect);*/

            //ExercicioVetores();

            // int result = EstudandoParametros.Soma(10, 20, 30, 40);
            //Console.WriteLine(result);

            //ExemploComListas();

            double[,] mat = new double[2, 3];
            
            VerificaFuncionario();
        }

        public static double UsandoVetor()
        {
            Console.WriteLine("Escreva um número");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            return avg;
        }

        public static double UsandoVetorComObjeto()
        {
            int n = int.Parse(Console.ReadLine());

            Produtos[] produto = new Produtos[n];
            

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produto[i] = new Produtos { Nome = nome, Preco = preco };

            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += produto[i].Preco;
            }

            double media = soma / n;
            return media;

        }

        public static void ExercicioVetores()
        {
            Console.WriteLine("Quantos quartos você deseja?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Estudantes[] estudante = new Estudantes[10];

            for (int i = 1; i <= qtdQuartos; i++)
            {
                Console.WriteLine("Seu nome");
                var nome = Console.ReadLine();

                Console.WriteLine("Seu e-mail: ");
                var email = Console.ReadLine();

                Console.WriteLine("Qual quarto você deseja? ");
                var n = int.Parse(Console.ReadLine());

                estudante[n] = new Estudantes{Nome = nome, Email = email};
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine($"{i} : {estudante[i]}");
                }
            }
        }

        public static void ExemplosComListas()
        {
            List<string> list = new List<string>();

            list.Add("Olá, Mundo");
            list.Add("Amanda");
            list.Add("João");
            list.Add("Ana");
            list.Add("Alan");

            //list.Insert(2, "Susana");
            //list.Remove("João");

            //list.RemoveAll(x => x[1] == 'm');
            list.RemoveRange(2, 2);
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'J');
            Console.WriteLine("Encontrar com a letra 'J'" + s1);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição com a letra A: " + pos1);

            List<string> resultado = list.FindAll(x => x.Length == 4);


            foreach (var obj in resultado)
            {
                Console.WriteLine(obj);
            }

        }

        public static void VerificaFuncionario()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("How many employees will be registered? ");
            int numEmployees = int.Parse(Console.ReadLine());

            List<Employees> listEmployee = new List<Employees>();

            for (int i = 1; i<= numEmployees; i++)
            {
                Console.WriteLine($"\nEmployee #{i}: ");
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("\nName: ");
                string name = Console.ReadLine();

                Console.Write("\nSalary: ");
                double salary = double.Parse(Console.ReadLine());

                listEmployee.Add(new Employees{Id = id, Name = name, Salary = salary});
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idSearch = int.Parse(Console.ReadLine());

            Employees empSearch = listEmployee.Find(c => c.Id == idSearch);
            if (empSearch != null)
            {
                Console.WriteLine($"Enter the percentage for employee {empSearch.Name}: ");
                double percentage = double.Parse(Console.ReadLine());
                empSearch.IncreaseSalary(percentage);
            }
            else
                Console.WriteLine("This employee doesn't exist!");

            Console.WriteLine("Update list of employees: ");
            foreach (var obj in listEmployee)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
