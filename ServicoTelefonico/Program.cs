using ServicoTelefonico.Entities;
using ServicoTelefonico.Utils;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Seja bem vindo ao sistema telefônico!\n");
Console.WriteLine("Selecione qual marca de telefone deseja adicionar: ");
bool exibirMarca = true;

while (exibirMarca)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - Iphone");
    Console.WriteLine("3 - Ligar");
    Console.WriteLine("4 - Receber Ligação");
    Console.WriteLine("5 - Sair do Sistema");
    switch (Console.ReadLine())
    { 
        case "1":
            Utils.MenuNokia();
            break;
        case "2":
            Utils.MenuIphone();
            break;
        case "3":
            Smartphone.Ligar();
            break;
        case "4":
            Smartphone.ReceberLigacao();
            break;
        case "5":
            exibirMarca = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
