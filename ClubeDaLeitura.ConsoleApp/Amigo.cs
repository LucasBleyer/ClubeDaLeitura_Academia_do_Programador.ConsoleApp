using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Amigo
    {
        public string nome;
        public string nome_responsavel;
        public string telefone;
        public string endereco;

        public void Registrar()
        {
            InserirTituloLimparTela("Registrar Amigos");
            Console.ReadKey();
        }

        public void Deletar()
        {
            InserirTituloLimparTela("Deletar Amigos");
            Console.ReadKey();
        }

        public void Editar()
        {
            InserirTituloLimparTela("Editar Amigos");
            Console.ReadKey();
        }

        public void Vizualizar()
        {
            InserirTituloLimparTela("Vizualizar Amigos");
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
