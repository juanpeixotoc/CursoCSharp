/*
 * Um construtor estático é um construtor especial que:
- Pertence à classe, não aos objetos
- É executado automaticamente uma única vez
- Roda antes do primeiro uso da classe
- Serve para inicializar dados estáticos

Ele não recebe parâmetros e não pode ser chamado manualmente.*/


Pessoa p

public class Pessoa
{
    public static int IdadeMinina;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
            Idade = idade;
            Nome = nome;
    }

    public Pessoa()
    {}

    static Pessoa()
    {
        IdadeMinina = 18;
         
    }
}