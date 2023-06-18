using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//Format, arredondamento
            Console.WriteLine(valor.ToString("C"));//Currency, formatando pro valor monetário
            Console.WriteLine(valor.ToString("P"));//Percent, valor percentual
            Console.WriteLine(valor.ToString("#.##"));//Cada # representa quantas casas voce quer que seja apresentado

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));//C de currency, sem casa decimal, com os parametros de cultura

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//Decimal, e caso o valor da formatação seja maior que o valor da var, ele irá completar com 0s a esquerda
        }
    }
}
