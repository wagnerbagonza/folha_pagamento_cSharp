using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Folha_de_Pagamento
{
    class Vendedor : Funcionario
    {
        private decimal venda;

        public Vendedor(string nome, decimal venda) : base(nome) 
        {
            this.venda = venda;
        }

        public decimal Comissao 
        {
            get { return venda; }
            set { venda = value; }
        }

        public override decimal CalculaSalario() 
        {
            decimal valor = 2000;

            return venda * Convert.ToDecimal(0.2) + valor; 
        }
    }
}
