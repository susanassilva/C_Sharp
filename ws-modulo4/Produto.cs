using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws_modulo4
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantiaEstoque;

        public double ValorTotalEmEstoque()
        {
           return Preco * QuantiaEstoque;
        }

        public void AdicionarProdutos(int auxiliar)
        {
            this.QuantiaEstoque += auxiliar;
        }

        public void RemoverProdutos(int auxiliar)
        {
            this.QuantiaEstoque -= auxiliar;
        }

        public override string ToString()
        {
            return Nome 
                   + ", " 
                   + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                   + ", " 
                   + QuantiaEstoque + ", " 
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
