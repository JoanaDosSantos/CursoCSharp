namespace CursoCSharp.Fundamentos
{
    class OperacoesDeUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);//Quando utilizado o -, o valor é invertido, logo o - vira + e etc
            Console.WriteLine(!booleano);//Negação lógica, o valor é invertido, logo o false vira true e etc

            numero1++;//numero1 = numero1 + 1, operador unário de incremento, operador pós fixado
            --numero2;//numero2 = numero2 - 1, operador unário de decremento, operador pré fixado, funcionam iguais
            Console.WriteLine($"{numero1}, {numero2}");

            Console.WriteLine(numero1++ == --numero2);
            //Por estar pré fixado, o numero2 será primeiro decrementado, pra depois ser avaliada a compara~ção, e 
            //só aí é acrescentado o numero1, pois está pós fixado. PORÉM NÃO É BOA PRÁTICA!!!
        }

    }
}
