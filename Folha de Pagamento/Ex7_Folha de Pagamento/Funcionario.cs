using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Folha_de_Pagamento
{
    class Funcionario : FolhadePagamento
    {
        private string nome;


        public Funcionario(string nome)
        {
            this.nome = nome;

        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public virtual decimal CalcularSalario()
        {
            return 0;
        
        }

    }
}
