public class Emprestimo
{
    //classe utilizada para imputar os dados do usuario e do livro a ser emprestado, assim podendo se ter varias utilidades esses dados.
    public Usuario Usuario { get; private set; }
    public Livro Livro { get; private set; }
    public DateTime DataEmprestimo { get; private set; }
    public DateTime DataDevolucao { get; private set; }
    public bool Ativo { get; private set; }

    public Emprestimo(Usuario usuario, Livro livro)
    {
        Usuario = usuario;
        Livro = livro;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = DataEmprestimo.AddDays(14);
        Ativo = true;
        livro.MarcarEmprestado();
    }

    public void RegistrarDevolucao()
    {
        Ativo = false;
        Livro.MarcarDevolvido();
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Usuário: {Usuario.Nome}, Livro: {Livro.Titulo}, Empréstimo: {DataEmprestimo.ToShortDateString()}, Devolução: {DataDevolucao.ToShortDateString()}, Ativo: {Ativo}");
    }
}