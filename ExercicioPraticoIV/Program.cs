

Potencia p = new();

int potenciaInicial = 10;
int novaPotencia = p.AumentarPotenciaVelocidade(potenciaInicial, out double velocidade);

Console.WriteLine($"Potência Inicial: {potenciaInicial}");
Console.WriteLine($"Nova Potência: {novaPotencia}");
Console.WriteLine($"Velocidade Calculada: {velocidade}");

Console.ReadLine();


public class Potencia
{
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        velocidade = potencia * 1.5;
        potencia += 7;
        return potencia;
    }
}