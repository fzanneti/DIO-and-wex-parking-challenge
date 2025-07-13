using System;
using System.Collections.Generic;
using System.Linq;
using parking.models;

namespace parking.services
{
    public class ParkingServices
    {
        private List<Veiculo> veiculos = new List<Veiculo>(); // Lista para armazenar os veículos estacionados.
        private decimal precoInicial = 5; // Preço inicial fixo cobrado ao estacionar o veículo.
        private decimal precoPorHora = 2; // Preço cobrado por hora de permanência no estacionamento.

        // Adiciona um veículo à lista com a placa fornecida e exibe uma mensagem de confirmação.
        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(new Veiculo(placa));
            Console.WriteLine("Veículo adicionado com sucesso.");
        }
        
        // Remove um veículo da lista pela placa, calcula o valor a pagar com base no tempo de permanência e exibe o resultado.
        public void RemoverVeiculo(string placa)
        {
            var veiculo = veiculos.FirstOrDefault(v => v.Placa == placa); // Busca o veículo pela placa usando LINQ.
            if (veiculo != null)
            {
                TimeSpan tempo = DateTime.Now - veiculo.HoraEntrada; // Calcula o tempo de permanência subtraindo a hora de entrada do momento atual.
                decimal valorTotal = precoInicial + (decimal)tempo.TotalHours * precoPorHora; // Calcula o valor total com base no preço inicial e no tempo em horas.
                veiculos.Remove(veiculo);
                Console.WriteLine($"Veículo removido. Tempo: {tempo.TotalMinutes:F0} minutos. Valor: R${valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        // Lista todos os veículos estacionados com suas placas e horários de entrada, ou exibe uma mensagem se não houver veículos.
        public void ListarVeiculos()
        {
            if (veiculos.Any()) // Verifica se há veículos na lista usando LINQ.
            {
                Console.WriteLine("Veículos no estacionamento:");
                foreach (var v in veiculos)
                    Console.WriteLine($"Placa: {v.Placa}, Entrada: {v.HoraEntrada}");
            }
            else
            {
                Console.WriteLine("Nenhum veículo estacionado.");
            }
        }

        // Altera o preço inicial, garantindo que o valor seja não negativo.
        public void AlterarPrecoInicial(decimal novoPreco)
        {
            if (novoPreco >= 0)
            {
                decimal precoAnterior = precoInicial; // Armazena o preço inicial anterior para exibição.
                precoInicial = novoPreco;
                Console.WriteLine($"Preço inicial alterado. Anterior: R${precoAnterior:F2}, Atual: R${novoPreco:F2}.");
            }
            else
            {
                Console.WriteLine("Erro: O preço inicial não pode ser negativo.");
            }
        }

        // Altera o preço por hora, garantindo que o valor seja não negativo. 
        public void AlterarPrecoPorHora(decimal novoPreco)
        {
            if (novoPreco >= 0)
            {
                decimal precoAnterior = precoPorHora; // Armazena o preço por hora anterior para exibição.
                precoPorHora = novoPreco;
                Console.WriteLine($"Preço por hora alterado. Anterior: R${precoAnterior:F2}, Atual: R${novoPreco:F2}.");
            }
            else
            {
                Console.WriteLine("Erro: O preço por hora não pode ser negativo.");
            }
        }

        // Exibe a tabela de preços atual com preço inicial e preço por hora.
        public void ExibirTabelaPrecos()
        {
            Console.WriteLine("Tabela de Preços:");
            Console.WriteLine($"Preço Inicial: R${precoInicial:F2}");
            Console.WriteLine($"Preço por Hora: R${precoPorHora:F2}");
        }
    }
}