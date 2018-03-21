using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Folha_de_Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            FolhadePagamento f = new FolhadePagamento();
            f.Adicionar(new Funcionario("Joao"));

            f.Adicionar(new Programador("Jose", 176, "junior"));
            f.Adicionar(new Programador("Augusto", 160, "pleno"));
            f.Adicionar(new Programador("Alice", 228, "senior"));
            f.Adicionar(new Gerente("Maria", 160, 1000));
            f.Adicionar(new Vendedor("Bob", 10000));
            f.ImprimirRelatorio();


        }
    }
}
