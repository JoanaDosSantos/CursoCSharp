namespace CursoCSharp.Fundamentos
{
    class OperacoesLogicos
    {
        public static void Executar()
        {
            //Operadores binários trabalham com dois operandos, comparando dois itens
            //Operadores unários trabalham com um operando só, invertendo seu valor 
            var executouTrab1 = true;
            var executouTrab2 = false;

            var comprouTv50 = executouTrab1 && executouTrab2;//And, E
            Console.WriteLine($"Comprou a Tv 50? {comprouTv50}");

            var comprouSorvete = executouTrab1 || executouTrab2;//Or, Ou
            Console.WriteLine($"Comprou o sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrab1 ^ executouTrab2;//Xor, Ou exclusivo
            Console.WriteLine($"Comprou a Tv 32? {comprouTv32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}");//Negação lógica

        }
    }
}
