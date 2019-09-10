using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Enum;

namespace TesteDotNet.Aplicacao.OperacoesCalculo
{
    public abstract class AbstractCalculadora : ICalculadora
    {
        public abstract decimal Calcular(Calculo calculo);

        public bool SeAplica(OperacoesEnum operacao)
        {
            return operacao == TipoOperacao();
        }

        public abstract OperacoesEnum TipoOperacao();
    }
}
