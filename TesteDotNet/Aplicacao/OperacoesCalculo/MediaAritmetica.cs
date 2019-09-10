using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDotNet.Dominio.Entidades;
using TesteDotNet.Dominio.Enum;

namespace TesteDotNet.Aplicacao.OperacoesCalculo
{
    public class MediaAritmetica : AbstractCalculadora
    {
        public override decimal Calcular(Calculo calculo)
        {
            return calculo.Numeros.Average();
        }

        public override OperacoesEnum TipoOperacao()
        {
            return OperacoesEnum.Media;
        }
    }
}
