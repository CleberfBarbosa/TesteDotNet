using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Enum;

namespace TesteDotNet.Aplicacao.OperacoesCalculo
{
    public interface ICalculadora
    {
        bool SeAplica(OperacoesEnum operacao);
        decimal Calcular(Calculo calculo);
    }
}
