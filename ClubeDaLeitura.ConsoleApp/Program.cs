using System;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        public static Amigo[] amigos = new Amigo[100];
        public static Caixa[] caixas = new Caixa[100];
        public static Revista[] revistas = new Revista[100];
        public static Emprestimo[] emprestimos = new Emprestimo[100];

        static void Main(string[] args)
        {
            while (true)
            {
                char opcao_menu_principal = MenuPrincipal();
                if (opcao_menu_principal == 's')
                {
                    break;
                }
                else
                {
                    VerificaOpcaoMenuPrincipal(opcao_menu_principal);
                }
            }
        }

        #region Métodos Menu Principal
        static char MenuPrincipal()
        {
            char opcao_menu_principal;
            do
            {
                InserirTituloLimpar("Clube da Leitura");
                Console.WriteLine("\n[1]Revista | [2]Caixa | [3]Empréstimo | [4]Amigo | [s]Sair");
                Console.Write("Digite uma opção: ");
                opcao_menu_principal = Convert.ToChar(Console.ReadLine().ToLower());
                if (opcao_menu_principal == 's')
                {
                    break;
                }
            } while (opcao_menu_principal != '1' && opcao_menu_principal != '2' && opcao_menu_principal != '3' && opcao_menu_principal != '4');
            return opcao_menu_principal;
        }

        static void VerificaOpcaoMenuPrincipal(char opcao_menu_principal)
        {
            switch (opcao_menu_principal)
            {
                case '1':
                    MenuRevista();
                    break;
                case '2':
                    MenuCaixa();
                    break;
                case '3':
                    MenuEmprestimo();
                    break;
                case '4':
                    MenuAmigo();
                    break;
            }
        }
        #endregion

        #region Métodos Menus Secundários
        static char MenuRevista()
        {
            char opcao_menu_principal;
            InserirTituloLimpar("Revista");
            return MostrarOpcoesCRUD(out opcao_menu_principal);
        }

        static char MenuCaixa()
        {
            char opcao_menu_principal;
            InserirTituloLimpar("Caixa");
            return MostrarOpcoesCRUD(out opcao_menu_principal);
        }
        static char MenuEmprestimo()
        {
            char opcao_menu_principal;
            InserirTituloLimpar("Empréstimo");
            return MostrarOpcoesCRUD(out opcao_menu_principal);
        }

        static char MenuAmigo()
        {
            char opcao_menu_principal;
            InserirTituloLimpar("Amigo");
            return MostrarOpcoesCRUD(out opcao_menu_principal);

        }
        #endregion

        #region Métodos Auxiliares

        static char MostrarOpcoesCRUD(out char opcao_crud)
        {
            do
            {
                Console.WriteLine("\n[1] Registrar | [2] Deletar | [3] Editar | [4] Vizualizar | [s] Voltar");
                Console.Write("Digite uma opção: ");
                opcao_crud = Convert.ToChar(Console.ReadLine().ToLower());
                if (opcao_crud == 's')
                {
                    break;
                }
            } while (opcao_crud != '1' && opcao_crud != '2' && opcao_crud != '3' && opcao_crud != '4');
            return opcao_crud;
        }

        static void InserirTituloLimpar(string mensagem)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        #endregion
    }
}