Carro car1 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro car2 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

//Console.WriteLine($"{car1.Modelo} {car1.Montadora} {car1.Marca} {car1.Ano} {car1.Potencia}");
//car1.Acelerar(car1.Marca);

//Console.WriteLine($"{car2.Modelo} {car2.Montadora} {car2.Marca} {car2.Ano} {car2.Potencia}");
//car2.Acelerar(car2.Marca);

car1.ExibirInfo(modelo: "Sedan", montadora: "Chevrolet", marca: "Onix", potencia: 110, ano: 2016);
car1.ExibirInfo(modelo: "Sedan", montadora: "Chevrolet", marca: "Onix", potencia: 110);


Console.ReadLine();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    private int? ano;
    public int? Ano 
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            if (value > 2022)
                ano = 2022;
            else ano = value;
        }
    }
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

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 0000)
    {
        Console.WriteLine($"Modelo: {modelo}, Montadora: {montadora}, Marca: {marca}, Potência: {potencia}, Ano: {ano}");
    }
}