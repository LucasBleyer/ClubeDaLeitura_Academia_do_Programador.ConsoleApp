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
        public DateTime data_emprestimo;
        public DateTime data_devolucao;

        public void Registrar()
        {
            InserirTituloLimparTela("Registrar Empréstimos");
            Console.ReadKey();
        }

        public void Deletar()
        {
            InserirTituloLimparTela("Deletar Empréstimos");
            Console.ReadKey();
        }

        public void Editar()
        {
            InserirTituloLimparTela("Editar Empréstimos");
            Console.ReadKey();
        }

        public void Vizualizar()
        {
            InserirTituloLimparTela("Vizualizar Empréstimos");
            Console.ReadKey();
        }
        public void InserirTituloLimparTela(string mensagem)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
