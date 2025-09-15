# WEX - End to End Engineering

## Sistema de parking com C# (.NET)

![GitHub repo size](https://img.shields.io/github/repo-size/fzanneti/dio-and-wex-parking-challenge)
![GitHub forks](https://img.shields.io/github/forks/fzanneti/dio-and-wex-parking-challenge?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/fzanneti/dio-and-wex-parking-challenge?style=social)
![Linguagem](https://img.shields.io/badge/Linguagem-CSharp-blue)
![Bootcamp](https://img.shields.io/badge/WEX-End--to--End%20Engineering-blueviolet?logo=vercel&logoColor=white)
![Plataforma](https://img.shields.io/badge/Powered%20by-DIO.io-red?logo=data:image/svg+xml;base64,PHN2ZyBmaWxsPSIjZmZmIiB2aWV3Qm94PSIwIDAgMzIgMzIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTYuNzEgMy4yNWMtMi44OCAxLjQxLTUuMDcgNC4yMy01LjA3IDcuNzYgMCAzLjU4IDIuMjggNi43IDUuMzMgOC4xNSAxLjgzLS42MiAyLjQtMi4yNiAyLjQtMy44MSAwLS4yMy0uMDItLjQ1LS4wNS0uNjZBLjQ0LjQ0IDAgMDExMC4xIDExYy4yNC0uNzUuMTEtMS41My0uMy0yLjIyQzguOTIgNy45NiA3LjMzIDcuNSA1Ljc0IDcuNjZhNS41NSA1LjU1IDAgM)
![Autor](https://img.shields.io/badge/Autor-fzanneti-blue?style=flat-square&logo=github)

---

### Visão Geral do Projeto

**Objetivo**

Desenvolver um sistema console simples, porém estruturado, para gerenciar a entrada e saída de veículos em um estacionamento. O sistema permite:

- Cadastro de veículos
- Remoção (saída) de veículos com cálculo do tempo estacionado e valor a pagar
- Listagem de veículos presentes
- Alteração do preço inicial e do preço por hora
- Exibição da tabela de preços
- Exibição da lista de veículos ao solicitar a remoção

---

### Arquitetura e Organização

> O projeto segue princípios de boas práticas, com separação de responsabilidades, legibilidade e foco em manutenção. A estrutura é a seguinte:

| **Caminho**|**Descrição** |
|--------------------------------------|----------------------------------------------------|
| 📁 `/parking`|Diretório principal do projeto|
| 📂 `/parking/models`|Contém as classes de domínio|
| 📄 `/parking/models/Vehicles.cs`|Define a entidade Veículo (placa e hora de entrada)|
| 📂 `/parking/services`|Contém a lógica de negócio|
| 📄 `/parking/services/ParkingServices.cs`|Gerencia operações do estacionamento|
| 📄 `/parking/Program.cs`|Ponto de entrada do programa|
| 📄 `/parking/parking.csproj`|Arquivo de projeto, configurado para .NET 8.0 |
| 📄 `dio-and-wex-parking-challenge.sln`|Arquivo de solução do projeto|
| 📄 `README.md`|Documentação do projeto|

---

### Requisitos Funcionais

- Registrar a entrada de um veículo com placa e hora de entrada.
- Remover um veículo pela placa, exibindo a lista de veículos estacionados antes da remoção, calculando o tempo estacionado e o valor a pagar.
- Exibir a lista de veículos atualmente no estacionamento.
- Alterar o preço inicial e o preço por hora, exibindo os valores anterior e atual.
- Exibir a tabela de preços com os valores atuais.
- Tratar erros, como:
  - Placa não encontrada ao remover.
  - Entrada inválida (ex.: valores não numéricos para preços).
- Utilizar um modelo de cobrança com valor fixo + valor por hora (ex.: R$ 5 fixo + R$ 2 por hora).

---

### Requisitos Não Funcionais

- Desenvolvido em C# com .NET 8.0.
- Interface em modo console com tela limpa após cada interação.
- Código modularizado com separação de responsabilidades.
- Código comentado e fácil de entender.
- Pausa após exibição de resultados para visualização antes de limpar a tela.

---

### Planejamento Inicial

**Casos de Uso**

1. **Entrada de Veículo**
   - Entrada: Placa do veículo.
   - Ação: Armazena a placa e a hora de entrada em uma lista.
2. **Saída de Veículo**
   - Entrada: Placa do veículo.
   - Ação: Exibe a lista de veículos, busca a placa, calcula o tempo estacionado e o valor total, remove o veículo da lista.
3. **Listagem de Veículos**
   - Ação: Exibe todas as placas e horários de entrada dos veículos estacionados.
4. **Alteração de Preços**
   - Entrada: Novo valor para preço inicial ou preço por hora.
   - Ação: Altera o valor, exibe o preço anterior e o atual, com validação para valores não negativos.
5. **Exibição da Tabela de Preços**
   - Ação: Mostra os valores atuais do preço inicial e preço por hora.

---

### Classes Implementadas

**`Veiculo.cs`**
   
```csharp

public class Veiculo
{
    public string Placa { get; set; }
    public DateTime HoraEntrada { get; set; }

    public Veiculo(string placa)
    {
        Placa = placa;
        HoraEntrada = DateTime.Now;
    }
}

```
- Representa um veículo com placa e hora de entrada.

**`Parkingservices.cs`**
   
```csharp

public class Parkingservices
{
    private decimal precoInicial = 5;
    private decimal precoPorHora = 2;
    private List<Veiculo> veiculos = new List<Veiculo>();

    public void AdicionarVeiculo(string placa) { /* lógica */ }
    public void RemoverVeiculo(string placa) { /* lógica */ }
    public void ListarVeiculos() { /* lógica */ }
    public void AlterarPrecoInicial(decimal novoPreco) { /* lógica */ }
    public void AlterarPrecoPorHora(decimal novoPreco) { /* lógica */ }
    public void ExibirTabelaPrecos() { /* lógica */ }
}

```
- Gerencia a lógica de negócio, incluindo adição, remoção, listagem, alteração de preços e exibição da tabela de preços.

---

### Interface no Console (`Program.cs`)
   
- Exibe um menu com as opções:
1. Adicionar Veículo
2. Remover Veículo (exibe lista de veículos antes da remoção)
3. Listar Veículos
4. Alterar Preço Inicial
5. Alterar Preço por Hora
6. Exibir Tabela de Preços
7. Sair
   
- Limpa a tela antes de cada menu ou interação (usando `Console.Clear()`).
- Pausa após cada ação (usando `Console.ReadKey()`) para permitir a visualização dos resultados.

---

### Atualizações Recentes

- Atualizado o framework para .NET 8.0.
- Adicionada opção para alterar o preço inicial e preço por hora, com exibição dos valores anterior e atual.
- Implementada exibição da tabela de preços.
- Adicionada listagem de veículos ao selecionar a opção de remoção, facilitando a escolha da placa.
- Interface aprimorada com limpeza de tela antes de cada interação e pausa para visualização de resultados.

---

### Certificado

<img src="https://github.com/fzanneti/DIO-wex-e2e-csharp/blob/main/Assets/images/certificados/13-construindo-um-sistema-para-um-estacionamento-com-CSharp.jpg" alt="Certificado" width="600px">

---

##### ✍️ Seção criada por: *Fabio Zanneti* - 🎯 Bootcamp: **WEX - End to End Engineering**
[![GitHub](https://img.shields.io/badge/GitHub-fzanneti-181717?style=flat&logo=github)](https://github.com/fzanneti)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-fzanneti-0A66C2?style=flat&logo=linkedin&logoColor=white)](https://linkedin.com/in/fzanneti)
