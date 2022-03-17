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

        public void Registrar(Amigo[] amigos, Amigo novo_amigo)
        {
            Console.Write("\nInforme o nome do amigo: ");
            novo_amigo.nome = Console.ReadLine();

            Console.Write("Informe o nome do responsável: ");
            novo_amigo.nome_responsavel = Console.ReadLine();

            Console.Write("Informe o telefone do amigo: ");
            novo_amigo.telefone = Console.ReadLine();

            Console.Write("Informe o endereço do amigo: ");
            novo_amigo.endereco = Console.ReadLine();

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                {
                    amigos[i] = novo_amigo;
                    break;
                }
            }
        }

        public void Deletar(Amigo[] amigos)
        {
            Vizualizar(amigos);

            Console.Write("Informe o ID do amigo a ser excluído: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());

            amigos[id_excluir] = null;

            Console.WriteLine("Amigo excluído!");
        }

        public void Editar(Amigo[] amigos)
        {
            Vizualizar(amigos);

            Console.Write("\nInforme o ID do amigo a ser editado: ");
            int id_editar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome do amigo: ");
            amigos[id_editar].nome = Console.ReadLine();

            Console.Write("Informe o nome do responsável: ");
            amigos[id_editar].nome_responsavel = Console.ReadLine();

            Console.Write("Informe o novo telefone do amigo: ");
            amigos[id_editar].telefone = Console.ReadLine();

            Console.Write("Informe o novo endereço do amigo: ");
            amigos[id_editar].endereco = Console.ReadLine();

            Console.WriteLine("Amigo editado!");
        }

        public void Vizualizar(Amigo[] amigos)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine("\nId: " + i);
                    Console.WriteLine("Nome do amigo: " + amigos[i].nome);
                    Console.WriteLine("Nome do responsável: " + amigos[i].nome_responsavel);
                    Console.WriteLine("Telefone do amigo: " + amigos[i].telefone);
                    Console.WriteLine("Endereço do amigo: " + amigos[i].endereco);
                }
            }
            Console.ReadLine();
        }
    }
}
