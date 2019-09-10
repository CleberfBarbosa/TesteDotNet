using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Enum;

namespace TesteDotNet.Aplicacao.OperacoesCalculo
{
    public class SomaMultiplos : AbstractCalculadora
    {
        public override decimal Calcular(Calculo calculo)
        {
            return calculo.Numeros.Sum();
        }

        public override OperacoesEnum TipoOperacao()
        {
            return OperacoesEnum.SomaMultiplos;
        }
    }
}
