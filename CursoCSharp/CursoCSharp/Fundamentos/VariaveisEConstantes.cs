using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Área da circunferencia
            double raio = 4.5; //Quando variável, sem var
            const double PI = 3.14; //Quando constante, const

            double area = raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é ", area);

            //Tipos internos
            bool estaChovendo = true; //booleano, true ou false
            Console.WriteLine("Está chovendo?" + estaChovendo);

            int precoSabao = 4; //Inteiro
            Console.WriteLine(precoSabao);

            float precoPc = 1532f; //Valor flutuante
            Console.WriteLine(precoPc);

            double precoAgua = 154.00; //Valor com virgula
            Console.WriteLine(precoAgua);

            char letra = 'b'; //Letra
            Console.WriteLine(letra);

            string texto = "Bem vindo ao tipo mais usado, a string!"; //cadeia de caracteres
            Console.WriteLine(texto);
        }
    }
}
