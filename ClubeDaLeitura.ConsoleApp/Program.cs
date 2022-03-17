﻿using System;

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
        #endregion

        #region Métodos CRUD de cada Classe
        static void MenuRevista()
        {
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);

            Revista nova_revista = new Revista();
            switch (opcao_crud)
            {

                case '1':
                    InserirTituloLimpar("Registrar Revistas");
                    nova_revista.Registrar(revistas, nova_revista);
                    break;
                case '2':
                    InserirTituloLimpar("Deletar Revistas");
                    nova_revista.Deletar(revistas);
                    break;
                case '3':
                    InserirTituloLimpar("Editar Revistas");
                    nova_revista.Editar(revistas);
                    break;
                case '4':
                    InserirTituloLimpar("Vizualizar Revistas");
                    nova_revista.Vizualizar(revistas);
                    break;
            }
        }

        static void MenuCaixa()
        {
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);

            Caixa nova_caixa = new Caixa();
            switch (opcao_crud)
            {
                case '1':
                    InserirTituloLimpar("Registrar Caixas");
                    nova_caixa.Registrar(caixas, nova_caixa);
                    break;
                case '2':
                    InserirTituloLimpar("Registrar Caixas");
                    nova_caixa.Deletar(caixas);
                    break;
                case '3':
                    InserirTituloLimpar("Registrar Caixas");
                    nova_caixa.Editar(caixas);
                    break;
                case '4':
                    InserirTituloLimpar("Registrar Caixas");
                    nova_caixa.Vizualizar(caixas);
                    break;
            }
        }

        static void MenuAmigo()
        {
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);
            Amigo novo_amigo = new Amigo();
            switch (opcao_crud)
            {
                case '1':
                    novo_amigo.Registrar(amigos, novo_amigo);
                    break;
                case '2':
                    novo_amigo.Deletar(amigos);
                    break;
                case '3':
                    novo_amigo.Editar(amigos);
                    break;
                case '4':
                    novo_amigo.Vizualizar(amigos);
                    break;
            }
        }
        static void MenuEmprestimo()
        {
            char opcao_crud;
            MostrarOpcoesCRUD(out opcao_crud);
            Emprestimo emprestimo = new Emprestimo();
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
        #endregion

        #region Métodos Auxiliares
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