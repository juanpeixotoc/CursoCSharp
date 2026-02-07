
Produto p1 = new();
p1.Nome = "Caderno";
p1.Preco = 4.00;
//p1.Desconto = 0.05;

p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();



public class Produto
{
    private string? nome;
    public string? Nome 
    { 
        get { return nome.ToUpper(); }
        set { nome = value; }
    }

    private double preco;
    public double Preco 
    { 
        get { return preco; } 
        set {
            if (preco < 5.00)
            {
                preco = 5;
            } else
            {
                preco = value;
            }
        }
    }

    private double desconto=0.05;
    public double Desconto 
    {
        get
        {
            return desconto;
        }
    }

    private double precoFinal;
    public double PrecoFinal 
    { 
        get
        {
          return Preco - (Preco * Desconto);
        }
    }

    private int minimo;
    public int EstoqueMinimo 
    {
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")}\n{Desconto}\n{PrecoFinal.ToString("c")}\n{minimo}");

    }
}