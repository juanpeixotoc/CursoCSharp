Console.WriteLine("This");


Teste t1 = new Teste();
t1.num1 = 10;
t1.num2 = 20;
t1.Exibir();

Teste t2 = new Teste();
t1.num1 = 88;
t1.num2 = 99;
t1.Exibir();

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;

    public Cliente(string? Nome, int Idade)
    {
        this.Nome = Nome;
        //usado this para identificar qual Nome é qual
        Idade = Idade;
    }
}




public class Teste
{
    public int num1;
    public int num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: " + t.num1);
        Console.WriteLine("Num2: " + t.num2);
    }

    public void Exibir()
    {
        // passando this como parametro (a classe Teste)
        PassarParametro(this);
    }
}