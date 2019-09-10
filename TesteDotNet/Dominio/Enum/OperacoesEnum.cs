using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesteDotNet.Dominio.Enum
{
    public enum OperacoesEnum
    {
        [Display(Name = "Inválido")]
        [Description("Operação inválida")]
        Invalido = 0,
        [Display(Name = "SOMA")]
        [Description("Soma")]
        Soma = 1,
        [Display(Name = "SUBTRACAO")]
        [Description("Subtração")]
        Subtracao = 2,
        [Display(Name = "DIVISAO")]
        [Description("Divisão")]
        Divisao = 3,
        [Display(Name = "MULTIPLICACAO")]
        [Description("Multiplicação")]
        Multiplicacao = 4,
        [Display(Name = "SOMA_DE_MULTIPLOS_NUMEROS")]
        [Description("Soma de multiplos números")]
        SomaMultiplos = 5,
        [Display(Name = "MEDIA_ARITMETICA")]
        [Description("Média aritmética")]
        Media = 6
    }
}
