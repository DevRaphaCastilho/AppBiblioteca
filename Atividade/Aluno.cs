public class Aluno : Usuario
{
    //classe utilizada para cadastrar os dados do aluno 
    public string Curso { get; set; }
    public string Matricula { get; set; }

    public Aluno(string nome, string id, string curso, string matricula)
        : base(nome, id, "Aluno")
    {
        Curso = curso;
        Matricula = matricula;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Aluno: {Nome}, ID: {Id}, Curso: {Curso}, Matrícula: {Matricula}");
    }
}