public class Livro
{
    //classe utilizada para cadastrar os dados do livro a ser cadastrado, e tbm puxar os dados de cada livro cadastrado
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public int Ano { get; private set; }
    public string ISBN { get; private set; }
    public bool Disponivel { get; private set; } = true;

    public Livro(string titulo, string autor, int ano, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        ISBN = isbn;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {Ano}, ISBN: {ISBN}, Disponível: {Disponivel}");
    }

    public void MarcarEmprestado() => Disponivel = false;
    public void MarcarDevolvido() => Disponivel = true;
}