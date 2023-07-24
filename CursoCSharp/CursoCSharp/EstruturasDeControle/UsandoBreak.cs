namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {

            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {numero}.");

            for (int i = 1; i <= 50; i++)
            {
                Console.Write($"{i} é o número que queremos? ");
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break;//O break é associado a switchs e a laços de repetição, então aqui ele sai do For (linha13) e não do If
                } else {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}