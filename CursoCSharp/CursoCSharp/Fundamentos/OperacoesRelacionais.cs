namespace CursoCSharp.Fundamentos
{
    class OperacoesRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite sua nota ");
            double nota = double.Parse(Console.ReadLine());
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota inválida?{nota > 10.0}");//Maior
            Console.WriteLine($"Nota inválida?{nota < 0.0}");//Menor
            Console.WriteLine($"Nota perfeita?{nota == 10.0}");//Igual
            Console.WriteLine($"Tem como melhorar?{nota != 10.0}");//Diferente
            Console.WriteLine($"Passou por média?{nota >= notaDeCorte}");//Maior ou igual
            Console.WriteLine($"Recuperação?{nota < notaDeCorte}");//Menor
            Console.WriteLine($"Reprovado?{(nota <= 3.0)}");//Menor ou igual


        }
    }
}
