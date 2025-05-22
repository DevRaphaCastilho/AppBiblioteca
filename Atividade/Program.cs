using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sistema = new SistemaBiblioteca();
        int opcao;
        //Aqui é o menu que é exibido para o usuário
        do
        {
            Console.WriteLine("\n=== Menu da Biblioteca ===");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Cadastrar Usuário");
            Console.WriteLine("3. Listar Livros Disponíveis");
            Console.WriteLine("4. Listar Usuários");
            Console.WriteLine("5. Realizar Empréstimo");
            Console.WriteLine("6. Registrar Devolução");
            Console.WriteLine("7. Histórico de Empréstimos por Usuário");
            Console.WriteLine("8. Livros Emprestados");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine());
            //Utilizei o switch para a escolha que o usuario optar, assim sendo coerente com sua escolha
            switch (opcao)
            {
                case 1:
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Ano: ");
                    int ano = int.Parse(Console.ReadLine());
                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine();
                    sistema.CadastrarLivro(new Livro(titulo, autor, ano, isbn));
                    break;
                case 2:
                    Console.Write("Tipo (aluno/professor): ");
                    string tipo = Console.ReadLine();
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("ID: ");
                    string id = Console.ReadLine();
                    if (tipo.ToLower() == "aluno")
                    {
                        Console.Write("Curso: ");
                        string curso = Console.ReadLine();
                        Console.Write("Matrícula: ");
                        string matricula = Console.ReadLine();
                        sistema.CadastrarUsuario(new Aluno(nome, id, curso, matricula));
                    }
                    else if (tipo.ToLower() == "professor")
                    {
                        Console.Write("Departamento: ");
                        string departamento = Console.ReadLine();
                        Console.Write("Registro: ");
                        string registro = Console.ReadLine();
                        sistema.CadastrarUsuario(new Professor(nome, id, departamento, registro));
                    }
                    break;
                case 3:
                    sistema.ListarLivrosDisponiveis();
                    break;
                case 4:
                    sistema.ListarUsuarios();
                    break;
                case 5:
                    Console.Write("Nome do usuário: ");
                    string nomeUsuario = Console.ReadLine();
                    Console.Write("Título do livro: ");
                    string tituloLivro = Console.ReadLine();
                    sistema.EmprestarLivro(nomeUsuario, tituloLivro);
                    break;
                case 6:
                    Console.Write("Nome do usuário: ");
                    nomeUsuario = Console.ReadLine();
                    Console.Write("Título do livro: ");
                    tituloLivro = Console.ReadLine();
                    sistema.DevolverLivro(nomeUsuario, tituloLivro);
                    break;
                case 7:
                    Console.Write("Nome do usuário: ");
                    nomeUsuario = Console.ReadLine();
                    sistema.HistoricoEmprestimosPorUsuario(nomeUsuario);
                    break;
                case 8:
                    sistema.ListarLivrosEmprestados();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 0);
    }
}