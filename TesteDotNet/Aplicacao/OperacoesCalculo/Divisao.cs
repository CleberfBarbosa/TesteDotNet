using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Enum;

namespace TesteDotNet.Aplicacao.OperacoesCalculo
{
    public class Divisao : AbstractCalculadora
    {
        public override decimal Calcular(Calculo calculo)
        {
            if (calculo.Numero2 == 0)
                throw new Exception("Não é possível realizar uma divisão por 0!");
            return calculo.Numero1 / calculo.Numero2;
        }

        public override OperacoesEnum TipoOperacao()
        {
            return OperacoesEnum.Divisao;
        }
    }
}
