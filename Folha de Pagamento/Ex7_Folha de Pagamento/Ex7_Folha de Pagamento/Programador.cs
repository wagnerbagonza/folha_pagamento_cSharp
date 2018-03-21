using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Folha_de_Pagamento
{
    class Programador : Funcionario
    {
        private string nivel;
        private double horas;

        public Programador(string nome, double horas, string nivel) : base(nome)
        {
           
            this.horas = horas;
            this.nivel = nivel;

        }

        public double Horas
        {
            get { return horas; }
            set { horas = value; }
        }
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
            
        }

        public override decimal CalcularSalario()
        {
            decimal valor = 0;

            switch (nivel)
            {
                case "junior":
                    valor = 30;
                    break;
                case "pleno":
                    valor = 45;
                    break;
                case "senior":
                    valor = 80;
                    break;
            }

            return Convert.ToDecimal(horas) * valor;

        }

    }
}
