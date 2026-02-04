

Aluno aluno = new Aluno("Maria", 22, "F", "aprovada");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? 0 : aluno.Idade);
Console.WriteLine(aluno.Sexo);
Console.WriteLine(aluno.Aprovado);


public class Aluno
{
    //digitar ctor cria um construtor sozinho
    public Aluno(string nome) => Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    /*this evita duplicação de construtor.
     * No caso, se esse construtor for chamado, ele irá executar da seguinte forma:
     * Executa: 2º construtor → chama 1º construtor → todos campos setados
     */
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

