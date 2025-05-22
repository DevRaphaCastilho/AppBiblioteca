public class Professor : Usuario
{
    //classe utilizada para cadastrar os dados do professor
    public string Departamento { get; set; }
    public string Registro { get; set; }

    public Professor(string nome, string id, string departamento, string registro)
        : base(nome, id, "Professor")
    {
        Departamento = departamento;
        Registro = registro;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Professor: {Nome}, ID: {Id}, Departamento: {Departamento}, Registro: {Registro}");
    }
}