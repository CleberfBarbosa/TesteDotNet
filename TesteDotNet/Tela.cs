using Infra.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDotNet.Aplicacao;
using TesteDotNet.Dominio.Enum;
using TesteDotNet.Infra;

namespace TesteDotNet
{
    public class Tela
    {
        private Calculadora calculadora;
        private List<OperacoesEnum> operacoes;
        public Tela()
        {
            calculadora = new Calculadora();
            operacoes = EnumExtensions.GetEnumList<OperacoesEnum>().Where(n => (int)n > 0).ToList();
        }

        public void TelaPrincipal()
        {
            ExibirMensagem("Seja bem vindo!!!");
            bool continuar = true;
            do
            {
                ExibirMensagem("Escolha abaixo o que você deseja fazer: " +
                "\n1 - Realizar um calculo manual" +
                "\n2 - Calcular os elementos do arquivo" +
                "\nESC - Para finalizar");
                var entrada = Console.ReadKey();
                switch (entrada.Key)
                {
                    case ConsoleKey.D1:
                        TelaCalculadora();
                        break;
                    case ConsoleKey.D2:
                        TelaCalculoArquivo();
                        break;
                    case ConsoleKey.Escape:
                        continuar = false;
                        break;
                    default:
                        ExibirMensagem("\tOpção inválida!");
                        break;
                }
            } while (continuar);
            ExibirMensagem("\tObrigado por utilizar nossa calculadora");
            System.Threading.Thread.Sleep(2000);
        }

        public void TelaCalculadora()
        {
            string operacoesString = string.Join("\n", operacoes.Select(n => $"{((int)n)} - {n.GetName()}"));
            do
            {
                ExibirMensagem("\nInforme o número ou nome da operação que você deseja realizar e os números, separados por ';'. Por exemplo: 'SOMA;12;32'");
                ExibirMensagem(operacoesString);
                var linha = Console.ReadLine();
                try
                {
                    var resultado = calculadora.Calcular(linha);
                    ExibirMensagem(resultado);
                }
                catch (Exception ex)
                {
                    ExibirMensagem($"\nErro: {ex.Message}");
                }
            } while (Continuar());
        }

        private bool Continuar()
        {
            ExibirMensagem("\n#############################################################################################################");
            ExibirMensagem("Pressione qualquer tecla para continuar ou ESC para sair. Para limpar a tela e continuar pressione a tecla 'L'.");
            ExibirMensagem("#############################################################################################################\n");
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.L:
                    Console.Clear();
                    return true;
                case ConsoleKey.Escape:
                    Console.Clear();
                    return false;
                default:
                    return true;
            }
        }

        public void TelaCalculoArquivo()
        {
            do
            {
                Console.WriteLine("\nAbaixo seguem os resultados dos calculos definidos no arquivo CSV.\n");
                try
                {
                    var resultado = calculadora.CalcularDoArquivo("calculos.csv");
                    foreach (var item in resultado)
                    {
                        ExibirMensagem($"{item.Key} - {item.Value}\n");
                    }
                }
                catch(Exception ex)
                {
                    ExibirMensagem(ex.Message);
                }
            } while (Continuar());
        }

        private static void ExibirMensagem(string mensagem)
        {
            Console.WriteLine($"{mensagem}");
        }
    }
}
