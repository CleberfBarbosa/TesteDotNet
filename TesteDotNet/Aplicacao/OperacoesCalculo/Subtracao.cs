using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Enum;

namespace TesteDotNet.Aplicacao.OperacoesCalculo
{
    public class Subtracao : AbstractCalculadora
    {
        public override decimal Calcular(Calculo calculo)
        {
            return calculo.Numero1 - calculo.Numero2;
        }

        public override OperacoesEnum TipoOperacao()
        {
            return OperacoesEnum.Subtracao;
        }
    }
}
