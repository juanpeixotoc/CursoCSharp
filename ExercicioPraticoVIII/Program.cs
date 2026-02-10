
Cliente cliente = new Cliente("Kian", "kian@gmail.com", 3);


Cliente.ExibirInfo(nome: cliente.Nome, email: cliente.Email, idade: cliente.Idade);
Cliente.ExibirInfo(nome: cliente.Nome, email: cliente.Email);


Console.ReadLine();


struct Cliente
{
    private string nome;
    public string? Nome { get; set; }
    private string email;
    public string? Email { get; set; }
    private int idade;
    public int Idade 
    {
        get { return idade;}
      set
        {
            if (value < 18)
                idade = 18;
            else
            {
                idade = value;
            }
        }
    }

    public Cliente(string? nome, string? email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string? nome, string? email, int idade=0)
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Idade: {idade}");
    }


}