using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConstrutoresMetodo
{
     class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)  {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }  
        public void RemoverProdutos(int quantidade)  {
            Quantidade  -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        }
}
