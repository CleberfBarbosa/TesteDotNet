using Infra.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Enum;
using TesteDotNet.Infra;

namespace TesteDotNet.Dominio.Entidades
{
    public class Calculo
    {
        public List<decimal> Numeros { get; set; }
        public OperacoesEnum Operacao { get; set; }
        public string NomeUsuario { get; set; }
        public decimal Numero1 => Numeros[0];
        public decimal Numero2 => Numeros[1];

        internal string FormatarResultado(decimal resultado)
        {
            return $"A {Operacao.GetDescription()} dos números: {string.Join(", ", Numeros)} resulta em {resultado}";
        }
    }
}
