using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Revista
    {
        public string tipo_colecao;
        public int numero_edicao;
        public DateTime ano_revista;
        public Caixa[] caixas;

        public void Registrar()
        {
            InserirTituloLimparTela("Registrar Revistas");
            Console.ReadKey();
        }

        public void Deletar()
        {
            InserirTituloLimparTela("Deletar Revistas");
            Console.ReadKey();
        }

        public void Editar()
        {
            InserirTituloLimparTela("Editar Revistas");
            Console.ReadKey();
        }

        public void Vizualizar()
        {
            InserirTituloLimparTela("Vizualizar Revistas");
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