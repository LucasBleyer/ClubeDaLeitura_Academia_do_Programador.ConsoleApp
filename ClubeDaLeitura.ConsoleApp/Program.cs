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
                char opcao = MenuPrincipal();
                if (opcao == 's')
                {
                    break;
                }
                else
                {
                    MenusSecundarios(opcao);
                }
            }
        }

        #region Métodos dos Menus
        static char MenuPrincipal()
        {
            char opcao_menu_principal;
            do
            {
                InserirTituloLimpar("Clube da Leitura");
                Console.WriteLine("\n[1]Revista | [2]Caixa | [3]Amigo | [4]Empréstimo | [s]Sair");
                Console.Write("Digite uma opção: ");
                opcao_menu_principal = Convert.ToChar(Console.ReadLine().ToLower());
                if (opcao_menu_principal == 's')
                {
                    break;
                }
            } while (opcao_menu_principal != '1' && opcao_menu_principal != '2' && opcao_menu_principal != '3' && opcao_menu_principal != '4');
            return opcao_menu_principal;
        }

        static void MenusSecundarios(char opcao_menus_secundarios)
        {
            switch (opcao_menus_secundarios)
            {
                case '1':
                    InserirTituloLimpar("Cadastro de Revistas");
                    MenuRevista();
                    break;
                case '2':
                    InserirTituloLimpar("Cadastro de Caixas");
                    MenuCaixa();
                    break;
                case '3':
                    InserirTituloLimpar("Cadastro de Amigos");
                    MenuAmigo();
                    break;
                    
                case '4':
                    InserirTituloLimpar("Cadastro de Empréstimos");
                    MenuEmprestimo();
                    break;
            }
        }

        static void MenuRevista()
        {
            Revista revista = new Revista();
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);
            switch (opcao_crud)
            {
                case '1':
                    revista.Registrar();
                    break;
                case '2':
                    revista.Deletar();
                    break;
                case '3':
                    revista.Editar();
                    break;
                case '4':
                    revista.Vizualizar();
                    break;
            }
        }

        static void MenuCaixa()
        {
            Caixa caixa = new Caixa();
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);
            switch (opcao_crud)
            {
                case '1':
                    caixa.Registrar();
                    break;
                case '2':
                    caixa.Deletar();
                    break;
                case '3':
                    caixa.Editar();
                    break;
                case '4':
                    caixa.Vizualizar();
                    break;
            }
        }

        static void MenuAmigo()
        {
            Amigo amigo = new Amigo();
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);
            switch (opcao_crud)
            {
                case '1':
                    amigo.Registrar();
                    break;
                case '2':
                    amigo.Deletar();
                    break;
                case '3':
                    amigo.Editar();
                    break;
                case '4':
                    amigo.Vizualizar();
                    break;
            }

        }
        static void MenuEmprestimo()
        {
            Emprestimo emprestimo = new Emprestimo();
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);
            switch (opcao_crud)
            {
                case '1':
                    emprestimo.Registrar();
                    break;
                case '2':
                    emprestimo.Deletar();
                    break;
                case '3':
                    emprestimo.Editar();
                    break;
                case '4':
                    emprestimo.Vizualizar();
                    break;
            }
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