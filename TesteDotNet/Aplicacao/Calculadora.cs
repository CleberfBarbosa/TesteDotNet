using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDotNet.Aplicacao.OperacoesCalculo;
using TesteDotNet.Infra.Mappers;
using TesteDotNet.Infra.Readers;

namespace TesteDotNet.Aplicacao
{
    public class Calculadora
    {
        private List<ICalculadora> calculos;
        private ReadCsv reader;

        public Calculadora()
        {
            calculos = new List<ICalculadora>()
            {
                new Soma(),
                new Subtracao(),
                new Divisao(),
                new Multiplicacao(),
                new MediaAritmetica(),
                new SomaMultiplos()
            };
            reader = new ReadCsv();
        }

        public string Calcular(string linha)
        {
            var calculo = CalculoMapper.CalculoElemento(linha);
            var resultado = calculos.FirstOrDefault(n => n.SeAplica(calculo.Operacao)).Calcular(calculo);
            return calculo.FormatarResultado(resultado);
        }

        public Dictionary<string, string> CalcularDoArquivo(string arquivo)
        {
            var listaLinhas = reader.LerCsv(arquivo);
            var retorno = new Dictionary<string, string>();
            foreach (var linha in listaLinhas)
            {
                try
                {
                    var calculo = CalculoMapper.CalculoLista(linha);
                    var resultado = calculos.FirstOrDefault(n => n.SeAplica(calculo.Operacao)).Calcular(calculo);
                    retorno.Add(calculo.NomeUsuario, calculo.FormatarResultado(resultado));
                }
                catch(Exception ex)
                {
                    retorno.Add(linha, $"Linha inválida {ex.Message}");
                }                
            }
            return retorno;
        }
    }
}
