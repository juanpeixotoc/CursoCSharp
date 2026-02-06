Potencia potencia = new Potencia();

Console.WriteLine(potencia.AumentarPotencia(5));

int valor = 5;
Console.WriteLine(potencia.AumentarPotenciaRef(ref valor));

Console.ReadLine();
public class Potencia
{
    public int AumentarPotencia(int valor)
    {
        return valor + 3;
    }

    public int AumentarPotenciaRef(ref int potencia)
    {
        return potencia + 5; 
    }
}