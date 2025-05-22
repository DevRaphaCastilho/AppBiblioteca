public abstract class Usuario
{
    //classe utilizada para cadastrar os dados do usuario
    public string Nome { get; set; }
    public string Id { get; set; }
    public string Tipo { get; set; }

    public Usuario(string nome, string id, string tipo)
    {
        Nome = nome;
        Id = id;
        Tipo = tipo;
    }

    public abstract void ExibirInformacoes();
}