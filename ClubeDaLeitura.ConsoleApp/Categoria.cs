using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Categoria
    {
        public string nome;
        public int quant_dias_emprestimo;
        //public Revista[] categorias;
        public int id_revista;

        public void Registrar(Categoria[] categorias, Categoria nova_categoria)
        {
            Console.Write("\nInforme o nome da categoria: ");
            nova_categoria.nome = Console.ReadLine();

            Console.Write("Informe a quantidade de dias de empréstimo: ");
            nova_categoria.quant_dias_emprestimo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o ID da revista a ser cadastrada: ");
            nova_categoria.id_revista = Convert.ToInt32(Console.ReadLine());

            DefinePosicaoCategoria(categorias, nova_categoria);     
        }

        static void DefinePosicaoCategoria(Categoria[] categorias, Categoria nova_categoria)
        {
            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] == null)
                {
                    categorias[i] = nova_categoria;
                    break;
                }
            }
        }

        public void Deletar(Categoria[] categorias)
        {
            Vizualizar(categorias);

            Console.Write("Informe o ID da categoria a ser excluída: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());

            categorias[id_excluir] = null;

            Console.WriteLine("Categoria excluída!");
        }

        public void Editar(Categoria[] categorias)
        {
            Vizualizar(categorias);

            Console.Write("\nInforme o ID da categoria a ser editada: ");
            int id_editar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o novo nome da categoria: ");
            categorias[id_editar].nome = Console.ReadLine();

            Console.Write("Informe a nova quatidade de dias de empréstimo: ");
            categorias[id_editar].quant_dias_emprestimo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o novo ID da revista a ser cadastrada na categoria: ");
            int id_revista = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Categoria editada!");
        }

        public void Vizualizar(Categoria[] categorias)
        {
            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null)
                {
                    Console.WriteLine("\nID da categoria: " + i);
                    Console.WriteLine("Nome da categoria: " + categorias[i].nome);
                    Console.WriteLine("Quantidade de dias de empréstimo da categoria: " + categorias[i].quant_dias_emprestimo);
                    Console.WriteLine("ID da revista: " + categorias[i].id_revista);
                }
            }
            Console.WriteLine("[Enter] para Continuar...");
            Console.ReadLine();
        }
    }
}
