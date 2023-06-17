using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            //o Console Readline  por padrão armazena o valor inserido numa string

            Console.Write("Qual é o sua idade? ");
            int idade = int.Parse(Console.ReadLine());


            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //O culture info vai ignorar se no país separa por ponto ou virgula e vai considerar sempre o ponto como separador de casas decimais
            //mas só dá pra utilizar isso por causa da biblioteca Globalization


            Console.WriteLine($"Seu nome é {nome}, sua idade é {idade} e você recebe o salário de R${salario}");
        }
    }
}
