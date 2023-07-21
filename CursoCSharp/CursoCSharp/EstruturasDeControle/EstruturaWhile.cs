namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        { 
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);//Valor de inicio e valor após o fim, logo vai ser entre 1 e 15
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado){
                Console.Write("Insira seu palpite entre 1 e 15: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Número encontrado com {tentativas} tentativas!");
                    Console.BackgroundColor = corAnterior;
                } 
                else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativas}");
                }
                else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativas}");
                }
            }
        }
    }
}
