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

        public void Registrar(Caixa[] caixas, Caixa nova_caixa)
        {
            Console.Write("\nInforme a cor da caixa: ");
            nova_caixa.cor = Console.ReadLine();

            Console.Write("Informe a etiqueta da caixa: ");
            nova_caixa.etiqueta = Console.ReadLine();

            Console.Write("Informe o número da caixa: ");
            nova_caixa.numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                {
                    caixas[i] = nova_caixa;
                    break;
                }
            }
        }

        public void Deletar(Caixa[] caixas)
        {
            Vizualizar(caixas);

            Console.Write("Informe o ID da caixa a ser excluída: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());

            caixas[id_excluir] = null;

            Console.WriteLine("Caixa excluída!");
        }

        public void Editar(Caixa[] caixas)
        {
            Vizualizar(caixas);

            Console.Write("\nInforme o ID da caixa a ser editada: ");
            int id_editada = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a nova cor da caixa: ");
            caixas[id_editada].cor = Console.ReadLine();

            Console.Write("Informe a nova etiqueta da caixa: ");
            caixas[id_editada].etiqueta = Console.ReadLine();

            Console.Write("Informe o novo número da caixa: ");
            caixas[id_editada].numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Caixa editada!");
        }

        public void Vizualizar(Caixa[] caixas)
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] != null)
                {
                    Console.WriteLine("\nId: " + i);
                    Console.WriteLine("Cor da caixa: " + caixas[i].cor);
                    Console.WriteLine("Etiqueta da caixa: " + caixas[i].etiqueta);
                    Console.WriteLine("Número da caixa: " + caixas[i].numero);
                }
            }
            Console.ReadLine();
        }
    }
}