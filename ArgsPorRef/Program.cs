
Console.WriteLine("##Args por referência");
int x = 20;
Console.WriteLine($"Valor de x antes do método: {x}");

Calculo calculo = new();
calculo.Dobrar(ref x);
Console.WriteLine($"Valor de x depois do método: {x}");


Console.ReadLine();

public class Calculo
{
    public void Dobrar(ref int valor)
    {
        valor *= 2;
        Console.WriteLine($"Valor dentro do método Dobrar: {valor}");
    }
}