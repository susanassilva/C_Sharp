using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_modulo4
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculaArea()
        {
            return Largura * Altura;
        }

        public double CalculaPerimetro()
        {
            return (2 * (Largura + Altura));

        }

        public double CalculaDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
