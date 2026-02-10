/*
 * tipo de dado definido pelo usuário que é composto por outros tipos de dados
 * - semelhante a classe
 * diferença: struct é um tipo de valor, enquanto a classe é um tipo de referência
 * 
 * usada se as instâncias forem pequenas e imutáveis, ou seja, não precisam ser modificadas após a criação
 * e de curta duração, ou seja, não precisam ser mantidas por um longo período de tempo
 */

Cliente cliente = new Cliente();
cliente.Nome = "João";
cliente.Idade = 30;
Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade}");

struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    
    public Cliente (string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
} 