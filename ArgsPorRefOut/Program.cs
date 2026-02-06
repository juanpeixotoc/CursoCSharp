
Console.WriteLine("Informe o valor do circulo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double circunferencia = circulo.CalcularAreaPerimetro(raio, out double area);
Console.WriteLine("Perímetro da circunferência: " + circunferencia);
Console.WriteLine("Área do círculo: " + area);



Console.ReadLine();

// a palavra-chave out é usada para passar argumentos por referência, quando se transfere dados para fora do método e nao para dentro
// nao precisam ser inicializadas  


public class Circulo
{
   public double CalcularAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}