// See https://aka.ms/new-console-template for more information
//Construtores
// construtor tem que ter o mesmo nome da classe

Console.WriteLine("##Construtores");

Aluno aluno = new Aluno("Maria", 22, "F", "aprovada");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? 0 : aluno.Idade);
Console.WriteLine(aluno.Sexo);
Console.WriteLine(aluno.Aprovado);


public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

