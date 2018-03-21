using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Folha_de_Pagamento
{
    class FolhadePagamento
    {
        private ArrayList funcionarios = new ArrayList();


        public void Adicionar(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }
        public void ImprimirRelatorio()
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                string nome = funcionario.Nome;
                decimal salario = funcionario.CalcularSalario();
                Console.WriteLine("{0} - {1:C}", nome,salario);
            }
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (Funcionario funcionario in funcionarios)
            {
                total += funcionario.CalcularSalario();
            }
            return total;
        }


    }
}
