namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");
            //concatenação padrão

            Console.WriteLine("O {0} da marca {1} custa {3}.", nome, marca, preco);
            //concatenação por interpolação

            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");
            //concatenação por interpolação

            Console.WriteLine($"1 + 1 = {1 + 1}.");
            //Demonstração de fórmula matematica dentro da interpolação

            //A interpolação é a interpretação do texto dentro das chaves para que seja apresentada ao usuário
        }
    }
}
