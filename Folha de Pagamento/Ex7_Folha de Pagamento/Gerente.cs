using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Folha_de_Pagamento
{
    class Gerente : Funcionario
    {
        private decimal bonus;
        private double horas;

        public Gerente(string nome, decimal bonus, double horas) : base(nome)
        {
            this.bonus = bonus;
            this.horas = horas;

        }

        public decimal Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public double Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        public override decimal CalcularSalario()
        {
            decimal valor = 100;

            return Convert.ToDecimal(horas) * valor + bonus;




        }





    }
}
