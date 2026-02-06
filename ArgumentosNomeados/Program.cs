Email email = new();

email.EnviarEmail(destino: "test@email.com", assunto: "Reunião Orçamento", titulo: "Urgente");
email.EnviarEmail(assunto: "Reunião Orçamento", destino: "test@email.com", titulo: "Urgente");
email.EnviarEmail(titulo: "Urgente", assunto: "Reunião Orçamento", destino: "test@email.com");

Console.ReadLine();


//Parâmetro: o valor que o método espera receber quando for chamado
// Argumento: o valor que é passado para o método quando ele é chamado


public class Email
{
    public void EnviarEmail(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"{destino} {titulo} {assunto}");
    }
}