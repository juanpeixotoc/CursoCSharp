
ContaBancaria[] contas = new ContaBancaria[100];
int total = 0;
int opcao;
string nome;
decimal valorInicial;
int numeroContaDeposito;
decimal valorDeposito;

do
{
    Console.WriteLine("Menu Principal: ");
    Console.Write(
        "1 - Criar conta\n" +
        "2 - Listar contas\n" +
        "3 - Depositar\n" +
        "4 - Sacar\n" +
        "5 - Transferir\n" +
        "6 - Sair\n" +
        "Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                Console.WriteLine("Criar conta");
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o valor inicial para Depósito:");
                valorInicial = decimal.Parse(Console.ReadLine());

                contas[total] = new ContaBancaria(nome, valorInicial);
                total++;

                break;
            }
        case 2:
            {
                Console.WriteLine("LISTAR CONTAS:");
                ListarContas(contas, total);
                break;
            }

        case 3:
            {
                Console.WriteLine("DEPOSITAR:");
                Console.WriteLine("Digite o número da conta: ");
                numeroContaDeposito = int.Parse(Console.ReadLine());

                ContaBancaria contaDestino = BuscarConta(numeroContaDeposito, contas, total);

                if (contaDestino != null)
                {
                    Console.WriteLine("digite o valor do depósito:");
                    valorDeposito = decimal.Parse(Console.ReadLine());

                    if (contaDestino.DepositarValor(valorDeposito))
                    {
                        Console.WriteLine("Depósito realizado");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. O depósito não pode ser nulo ou negativo");
                    }

                }
                else
                {
                    Console.WriteLine("Conta não encontrada");
                }
                break;
            }
        case 4:
            {
                Console.WriteLine("SACAR");
                Console.WriteLine("Digite o número da conta: ");
                numeroContaDeposito = int.Parse(Console.ReadLine());

                ContaBancaria contaSaque = BuscarConta(numeroContaDeposito, contas, total);

                if (contaSaque!= null)
                {
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());

                    if (contaSaque.SacarValor(valorSaque))
                    {
                        Console.WriteLine("Saque realizado.");
                    }
                    else
                    {
                        Console.WriteLine("Saque não realizado");
                    }

                }
                break;
            }
        case 5:
            {
                Console.WriteLine("TRANSFERIR");
                Console.WriteLine("Digite a conta de origem: ");
                int numeroContaOrigem = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a conta de destino: ");
                int numeroContaDestino = int.Parse(Console.ReadLine());

                ContaBancaria contaOrigem = BuscarConta(numeroContaOrigem, contas, total);
                ContaBancaria contaDestino = BuscarConta(numeroContaDestino, contas, total);

                if (contaOrigem != null && contaDestino != null)
                {
                    Console.WriteLine("Informe o valor da transferência: ");
                    decimal valorTransferencia = decimal.Parse(Console.ReadLine());

                   if (contaOrigem.Transferir(contaDestino, valorTransferencia))
                    {
                        Console.WriteLine("Transferência realizada com sucesso.");
                    } else
                    {
                        Console.WriteLine("Transferência não realizada.");
                    }

                } else
                {
                    Console.WriteLine("Contas não encontradas.");
                }

                    break;
            }
        case 6:
            {
                break;
            }
    }

} while (opcao != 6);



Console.ReadLine();


static void ListarContas(ContaBancaria[] contas, int total)
{
    if (total == 0)
    {
        Console.WriteLine("Nenhuma conta encontrada.");
    }
    else
    {
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine($"Conta: {contas[i].NumeroConta} | " +
                $"Titular: {contas[i].NomeTitular} | " +
                $"Saldo: {contas[i].Saldo:C}");
        }
    }
}

static ContaBancaria? BuscarConta(int numero, ContaBancaria[] contas, int total)
{
    for (int i = 0; i < total; i++)
    {
        if (contas[i].NumeroConta == numero)
        {
            return contas[i];
        }
    }
    return null;
}
public class ContaBancaria
{
    private static int proximoNumero = 1;

    private int numeroConta;
    public int NumeroConta
    {
        get { return numeroConta; }
    }
    private string? nomeTitular;
    public string? NomeTitular
    {
        get { return nomeTitular; }
        set { nomeTitular = value; }
    }
    private decimal saldo;
    public decimal Saldo
    {
        get { return saldo; }
    }

    public ContaBancaria(string? titular, decimal valorInicial)
    {
        numeroConta = proximoNumero++;
        nomeTitular = titular;
        saldo = valorInicial >= 0 ? valorInicial : 0;
    }

    public bool DepositarValor(decimal valor)
    {
        if (valor <= 0)
            return false;
        else
        {
            saldo += valor;
            return true;
        }
    }

    public bool SacarValor(decimal valor)
    {
        if ((valor <= 0) || (saldo < valor))
        {
            return false;
        } else
        {
            saldo -= valor;
            return true;
        }
    }

    public bool Transferir(ContaBancaria destino, decimal valor)
    {
        if (destino == null)
            return false;

        if (valor <= 0)
            return false;

        if (!SacarValor(valor))
            return false;

        destino.DepositarValor(valor);
        return true;

    }

   

}