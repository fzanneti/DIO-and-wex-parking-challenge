using parking.services;

class Program
{   
    // Método principal que serve como ponto de entrada do programa.
    static void Main(string[] args)
    {
        ParkingServices estacionamento = new ParkingServices(); // Instancia o serviço de estacionamento para gerenciar veículos.

        while (true) // Loop infinito para exibir o menu até que o usuário escolha sair.
        {
            Console.Clear(); // Limpa a tela do console antes de exibir o menu, proporcionando uma interface renovada.
            Console.WriteLine("\n1 - Adicionar Veículo");
            Console.WriteLine("2 - Remover Veículo");
            Console.WriteLine("3 - Listar Veículos");
            Console.WriteLine("4 - Alterar Preço Inicial");
            Console.WriteLine("5 - Alterar Preço por Hora");
            Console.WriteLine("6 - Exibir Tabela de Preços");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("Escolha uma opção: ");
            string opcao = Console.ReadLine() ?? ""; // Lê a entrada do usuário, tratando nulo como string vazia.

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a placa do veículo: ");
                    estacionamento.AdicionarVeiculo(Console.ReadLine() ?? ""); // Chama o método para adicionar veículo com a placa fornecida.
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Aguarda uma tecla para permitir que o usuário veja a mensagem antes de limpar a tela.
                    break;
                case "2":
                    Console.Clear(); // Limpa a tela para exibir a lista de veículos de forma limpa.
                    estacionamento.ListarVeiculos(); // Exibe a lista de veículos estacionados para auxiliar na escolha da placa.
                    Console.Write("\nDigite a placa do veículo a remover: ");
                    estacionamento.RemoverVeiculo(Console.ReadLine() ?? ""); // Chama o método para remover veículo com a placa fornecida.
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Aguarda uma tecla para permitir que o usuário veja a mensagem antes de limpar a tela.
                    break;
                case "3":
                    estacionamento.ListarVeiculos(); // Chama o método para listar todos os veículos.
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Aguarda uma tecla para permitir que o usuário veja a lista antes de limpar a tela.
                    break;
                case "4":
                    Console.Write("Digite o novo preço inicial (R$): ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal novoPrecoInicial)) // Tenta converter a entrada para decimal.
                    {
                        estacionamento.AlterarPrecoInicial(novoPrecoInicial); // Chama o método para alterar o preço inicial.
                    }
                    else
                    {
                        Console.WriteLine("Erro: Entrada inválida. Use um valor numérico.");
                    }
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Aguarda uma tecla para permitir que o usuário veja a mensagem antes de limpar a tela.
                    break;
                case "5":
                    Console.Write("Digite o novo preço por hora (R$): ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal novoPrecoPorHora)) // Tenta converter a entrada para decimal.
                    {
                        estacionamento.AlterarPrecoPorHora(novoPrecoPorHora); // Chama o método para alterar o preço por hora.
                    }
                    else
                    {
                        Console.WriteLine("Erro: Entrada inválida. Use um valor numérico.");
                    }
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Aguarda uma tecla para permitir que o usuário veja a mensagem antes de limpar a tela.
                    break;
                case "6":
                    estacionamento.ExibirTabelaPrecos(); // Chama o método para exibir a tabela de preços.
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Aguarda uma tecla para permitir que o usuário veja a tabela antes de limpar a tela.
                    break;
                case "7":
                    return; // Encerra o programa ao sair do método Main.
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey(); // Aguarda uma tecla para permitir que o usuário veja a mensagem antes de limpar a tela.
                    break;
            }
        }
    }
}