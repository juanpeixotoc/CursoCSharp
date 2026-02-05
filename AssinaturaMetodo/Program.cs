//sobrecarga de metodos
//1 - numero de parametros diferentes
// 2 - tipos de dados diferentes
//3- ordem dos parametros diferentes

Email email = new Email();

email.Enviar("juanpeixotob@gmail.com");
email.Enviar("juanpeixotob@gmail.com", "Teste");
email.Enviar("juanpeixotob@gmail.com", 15);
email.Enviar(15, "juanpeixotob@gmail.com");

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto padrao");

    }
    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");

    }

    public void Enviar (string endereco,decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{valor}");
    }
}