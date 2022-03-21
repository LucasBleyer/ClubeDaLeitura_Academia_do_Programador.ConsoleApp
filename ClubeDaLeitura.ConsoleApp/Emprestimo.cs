using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Emprestimo
    {
        //public Amigo[] amigos;
        //public Revista[] revistas;
        public string data_emprestimo;
        public string data_devolucao;

        public void Registrar(Emprestimo[] emprestimos, Emprestimo novo_emprestimo)
        {
            Console.Write("Informe o data do empréstimo: ");
            novo_emprestimo.data_emprestimo = Console.ReadLine();

            Console.Write("Informe a data prevista para a devolução da revista: ");
            novo_emprestimo.data_devolucao = Console.ReadLine();

            DefinePosicaoEmprestimo(emprestimos, novo_emprestimo);
        }

        static void DefinePosicaoEmprestimo(Emprestimo[] emprestimos, Emprestimo novo_emprestimo)
        {
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

            Console.WriteLine("Empréstimo excluído!");
        }

        public void Editar(Emprestimo[] emprestimos)
        {
            Vizualizar(emprestimos);

            Console.Write("Informe o ID do empréstimo a ser editado: ");
            int id_editar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a nova data do empréstimo ");
            emprestimos[id_editar].data_emprestimo = Console.ReadLine();

            Console.Write("Informe a nova data prevista para a devolução da revista ");
            emprestimos[id_editar].data_devolucao = Console.ReadLine();

            Console.WriteLine("Empréstimo editado!");
        }

        public void Vizualizar(Emprestimo[] emprestimos)
        {
            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos[i] != null)
                {
                    Console.WriteLine("Id do empréstimo: " + i);
                    Console.WriteLine("Data do empréstimo: " +emprestimos[i].data_emprestimo);
                    Console.WriteLine("Data de devolução: " +emprestimos[i].data_devolucao);
                }
            }
            Console.WriteLine("\n[Enter] para Continuar...");
            Console.ReadLine();
        }
    }
}
