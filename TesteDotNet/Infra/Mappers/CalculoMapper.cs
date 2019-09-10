using Infra.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TesteDotNet.Dominio;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Enum;

namespace TesteDotNet.Infra.Mappers
{
    public static class CalculoMapper
    {
        public static Calculo CalculoLista(string linha)
        {
            List<string> elementosLinha = ObterElementosLinha(linha);
            if (elementosLinha.Count < 4)
                throw new Exception("É necessário informar ao menos 4 dados, a operação que irá executar necessita de no mínimo:" +
                    " seu nome, a operação e 2 números");
            return new Calculo
            {
                Numeros = ObterNumeros(elementosLinha.Skip(2)),
                Operacao = ObterOperacao(elementosLinha[1]),
                NomeUsuario = elementosLinha[0] ?? string.Empty
            };
        }

        public static Calculo CalculoElemento(string linha)
        {
            var elementosLinha = ObterElementosLinha(linha);
            if (elementosLinha.Count < 3)
                throw new Exception("É necessário informar ao menos 3 dados, a operação que irá executar necessita de no mínimo:" +
                    " a operação e 2 números");
            return new Calculo
            {
                Numeros = ObterNumeros(elementosLinha.Skip(1)),
                Operacao = ObterOperacao(elementosLinha[0])
            };
        }

        private static List<string> ObterElementosLinha(string linha)
        {
            if (string.IsNullOrEmpty(linha))
                throw new Exception("Linha inválida!");
            var elementosLinha = linha.ToUpper()?.Split(';')?.ToList()?.Select(n => n.Trim())?.ToList() ?? new List<string>();
            return elementosLinha;
        }

        private static List<decimal> ObterNumeros(IEnumerable<string> elementos)
        {
            var numeros = new List<decimal>();
            foreach (var elemento in elementos)
            {
                try
                {
                    var numero = decimal.Parse(elemento.Replace(".", ","));
                    numeros.Add(numero);
                }
                catch (Exception)
                {
                    throw new Exception($"O número '{elemento}' é inválido!");
                }
            }
            return numeros;
        }

        private static OperacoesEnum ObterOperacao(string operacaoString)
        {
            int.TryParse(operacaoString, out int numeroOperacao);
            var listaOperacoes = EnumExtensions.GetEnumList<OperacoesEnum>();
            var teste = Regex.Replace(operacaoString, @"[^\w\d\s]", "");
            var operacao = numeroOperacao > 0 ? listaOperacoes.FirstOrDefault(n => (int)n == numeroOperacao)
                : listaOperacoes.FirstOrDefault(n => n.GetName().Equals(operacaoString, StringComparison.CurrentCultureIgnoreCase));
            if (operacao == OperacoesEnum.Invalido)
                throw new Exception("Operação inválida");
            return operacao;
        }
    }
}
