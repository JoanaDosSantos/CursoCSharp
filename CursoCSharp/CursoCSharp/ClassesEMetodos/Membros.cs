namespace CursoCSharp.ClassesEMetodos
{
    public class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new()
            {
                Nome = "Renato",
                Idade = 21
            };

            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade}");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);

        }
    }
}
