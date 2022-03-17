using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Emprestimo
    {
        public Amigo[] amigos;
        public Revista[] revistas;
        public string data_emprestimo;
        public string data_devolucao;

        public void Registrar(Emprestimo[] emprestimos, Emprestimo novo_emprestimo)
        {
            Console.WriteLine("Informe o data do empréstimo: ");
            novo_emprestimo.data_emprestimo = Console.ReadLine();

            Console.WriteLine("Informe a data prevista para a devolução da revista: ");
            novo_emprestimo.data_devolucao = Console.ReadLine();

            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos[i] == null)
                {
                    emprestimos[i] = novo_emprestimo;
                    break;
                }
            }

        }

        public void Deletar(Emprestimo[] emprestimos)
        {
            Vizualizar(emprestimos);

            Console.Write("Informe o ID do empréstimo a ser excluído: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());

            emprestimos[id_excluir] = null;

            Console.WriteLine("Empréstimo Excluído!");
        }

        public void Editar(Emprestimo[] emprestimos)
        {
            Vizualizar(emprestimos);
        }

        public void Vizualizar(Emprestimo[] emprestimos)
        {

        }
    }
}
