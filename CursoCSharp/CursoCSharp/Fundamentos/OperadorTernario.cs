namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            //O operador ternário é composto por: Uma expressão que o torna verdadeiro ou falso, uma expressão caso seja verdade e uma caso seja falso
            //Expressão = operando1 : operando2, também é uma operação de condição

            var nota = 7;
            bool bomComportamento = true;
            string resultado = nota >= 7 ? "Aprovado" : "Reprovado";
            //     resultado =  condição ? caso verdade : caso falsa
            string resultado2 = nota >= 7 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine($"{resultado}, {resultado2}");

        }
    }
}
