public class SistemaBiblioteca
{
    //Aqui geramos as listas onde, serao gravados os dados

    private List<Livro> livros = new List<Livro>();
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Emprestimo> emprestimos = new List<Emprestimo>();

    //Void utilizado para sempre voltar se quiser cadastrar outro livro ou usuario, e mostrar os livros disponiveis
    public void CadastrarLivro(Livro livro) => livros.Add(livro);
    public void CadastrarUsuario(Usuario usuario) => usuarios.Add(usuario);

    public void ListarLivrosDisponiveis()
    {
        //laço
        foreach (var livro in livros.Where(l => l.Disponivel))
        {
            //Aqui utilizamos para exibir as informações dos livros
            livro.ExibirInformacoes();
        }
    }

    public void ListarUsuarios()
    {
        foreach (var usuario in usuarios)
        {
            usuario.ExibirInformacoes();
        }
    }
    //Função emprestrar o livro, onde se utiliza os dados do usuario que quer emprestar e os livros disponiveis
    public void EmprestarLivro(string nomeUsuario, string tituloLivro)
    {
        var usuario = usuarios.FirstOrDefault(u => u.Nome.Equals(nomeUsuario, StringComparison.OrdinalIgnoreCase));
        var livro = livros.FirstOrDefault(l => l.Titulo.Equals(tituloLivro, StringComparison.OrdinalIgnoreCase) && l.Disponivel);

        if (usuario != null && livro != null)
        {
            var e = new Emprestimo(usuario, livro);
            emprestimos.Add(e);
            Console.WriteLine("Empréstimo realizado com sucesso!");
        }
        else
        {
            //ERRO CASO O LIVRO NAO ESTEJA DISPONIVEL, OU CADASTRO DE USUARIO NAO ENCONTRADO.
            Console.WriteLine("Usuário ou livro não encontrado/disponível.");
        }
    }
    //Função para devolver o livro, se o livro que for devolvido não estiver emprestado, o else será executado.
    public void DevolverLivro(string nomeUsuario, string tituloLivro)
    {
        var emprestimo = emprestimos.FirstOrDefault(e => e.Ativo && e.Usuario.Nome.Equals(nomeUsuario, StringComparison.OrdinalIgnoreCase) && e.Livro.Titulo.Equals(tituloLivro, StringComparison.OrdinalIgnoreCase));
        if (emprestimo != null)
        {
            emprestimo.RegistrarDevolucao();
            Console.WriteLine("Devolução registrada com sucesso!");
        }
        else
        {
            Console.WriteLine("Empréstimo ativo não encontrado.");
        }
    }
    //Função utilizada para exibir, como se fosse um extrado(resumo) dos livros emprestados pelo usuario
    public void HistoricoEmprestimosPorUsuario(string nomeUsuario)
    {
        foreach (var e in emprestimos.Where(e => e.Usuario.Nome.Equals(nomeUsuario, StringComparison.OrdinalIgnoreCase)))
        {
            e.ExibirResumo();
        }
    }
    //Função utilizada para exibir, como se fosse uma lista dos livros emprestados que o usuario está ainda utilizando
    public void ListarLivrosEmprestados()
    {
        foreach (var e in emprestimos.Where(e => e.Ativo))
        {
            e.ExibirResumo();
        }
    }
}