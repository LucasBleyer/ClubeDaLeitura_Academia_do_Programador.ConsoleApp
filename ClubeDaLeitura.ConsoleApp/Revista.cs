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
        public string ano_revista;

        public void Registrar(Revista[] revistas, Revista nova_revista)
        {
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
            Vizualizar(revistas);

            Console.Write("Informe o ID da revista a ser excluída: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());

            revistas[id_excluir] = null;

            Console.WriteLine("Revista excluída!");
        }

        public void Editar(Revista[] revistas)
        {
            Vizualizar(revistas);

            Console.Write("\nInforme o ID da revista a ser editada: ");
            int id_editada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o novo tipo de coleção: ");
            revistas[id_editada].tipo_colecao = Console.ReadLine();

            Console.Write("Informe o novo número da edição: ");
            revistas[id_editada].numero_edicao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a novo data de fabricação: ");
            revistas[id_editada].ano_revista = Console.ReadLine();

        }

        public void Vizualizar(Revista[] revistas)
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] != null)
                {
                    Console.WriteLine("\nId: " + i);
                    Console.WriteLine("Tipo de coleção: " + revistas[i].tipo_colecao);
                    Console.WriteLine("Número da Edição: " + revistas[i].numero_edicao);
                    Console.WriteLine("Ano da revista: " + revistas[i].ano_revista);
                }
            }
            Console.ReadLine();
        }
    }
}