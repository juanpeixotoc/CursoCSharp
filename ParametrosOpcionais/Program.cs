
Console.ReadLine();


public class Email
{
    // parametros obrigatorios
    public void EnviarEmail(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"{destino} {titulo} {assunto}");
    }

    //parametros opcionais
    public void EnviarEmailOpcional(string destino, string titulo = "Sem Título", string assunto = "Sem Assunto")
    //dessa forma, se o usuario nao passar o titulo ou assunto, ele vai usar os valores padroes
    {
        Console.WriteLine($"{destino} {titulo} {assunto}");
    }
}