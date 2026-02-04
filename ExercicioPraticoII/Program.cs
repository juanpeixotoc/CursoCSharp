/*
g- Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
use a palavra-chave this)
i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
vai retornar um double representando a velocidade máxima do carro
( Para calcular a velocidade multiplique a potencia por 1.75)
h- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
j- Explique o comportamento da palavra return 
 */

Carro car1 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro car2 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"{car1.Modelo} {car1.Montadora} {car1.Marca} {car1.Ano} {car1.Potencia}");
car1.Acelerar(car1.Marca);

Console.WriteLine($"{car2.Modelo} {car2.Montadora} {car2.Marca} {car2.Ano} {car2.Potencia}");
car2.Acelerar(car2.Marca);

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int? Ano;
    public int? Potencia;

    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    // A instrução return é usada para encerrar a execução do método e retornar o controle de volta ao
    // método chamador retornando o valor do tipo definido no método.
    public void Acelerar(string marca)
    {
        Console.WriteLine("Acelerando o meu " + marca);
    }
}