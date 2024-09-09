using SistemaParaEstacionamentoComCsharp.models;
using System;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoIncial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao Sistema de Estacionamento!\n" +
                  "Digite o preço incial:");

// Converte a string para decimal e lê o texto inserido pelo usuário
precoIncial = Convert.ToDecimal(Console.ReadLine());  

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Estância a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoIncial, precoPorHora);

string opcao = string.Empty;
bool exibir.Menu = true;

while (exibir.Menu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch(Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        
        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibir.Menu = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
