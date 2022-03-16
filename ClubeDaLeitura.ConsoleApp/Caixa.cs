using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Caixa
    {
        public string cor;
        public string etiqueta;
        public int numero;

        public void Registrar()
        {
            InserirTituloLimparTela("Registrar Caixas");
            Console.ReadKey();
        }

        public void Deletar()
        {
            InserirTituloLimparTela("Deletar Caixas");
            Console.ReadKey();
        }

        public void Editar()
        {
            InserirTituloLimparTela("Editar Caixas");
            Console.ReadKey();
        }

        public void Vizualizar()
        {
            InserirTituloLimparTela("Vizualizar Caixas");
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