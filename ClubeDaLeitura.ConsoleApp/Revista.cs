using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Revista
    {
        public int id_revista;
        public string tipo_colecao;
        public int numero_edicao;
        public string ano_revista;

        public void Registrar(Revista[] revistas, Revista nova_revista)
        {
            InserirTituloLimparTela("Registrar Revistas");

            Console.Write("\nInforme o tipo de coleção: ");
            nova_revista.tipo_colecao = Console.ReadLine();

            Console.Write("Informe o número da edição: ");
            nova_revista.numero_edicao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a data de fabricação: ");
            nova_revista.ano_revista = Console.ReadLine();

            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] == null)
                {
                    revistas[i] = nova_revista;
                    break;
                }
            }
        }

        public void Deletar(Revista[] revistas)
        {
            InserirTituloLimparTela("Deletar Revistas");
            Console.Write("\nInforme o ID da revista a ser excluída: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());

            revistas[id_excluir] = null;
        }

        public void Editar()
        {
            InserirTituloLimparTela("Editar Revistas");
            Console.ReadKey();
        }

        public void Vizualizar(Revista[] revistas)
        {
            InserirTituloLimparTela("Vizualizar Revistas");
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] != null)
                {
                    Console.WriteLine("\nId: " + i);
                    Console.WriteLine("Tipo de coleção: " + revistas[i].tipo_colecao);
                    Console.WriteLine("Número da Edição: " + revistas[i].numero_edicao);
                    Console.WriteLine("Ano da revista: " + revistas[i].ano_revista + "\n");
                }
            }
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