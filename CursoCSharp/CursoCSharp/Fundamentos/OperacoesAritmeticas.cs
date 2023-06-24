namespace CursoCSharp.Fundamentos
{
    class OperacoesAritmeticas
    {
        public static void Executar()
        {
            //Preço desconto
            Console.WriteLine("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do imposto: ");
            double imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu desconto promocional é de 10%");
            var desconto = 0.10;

            double total = preco + imposto;
            var totalCmDesconto = total - total * desconto;
            Console.WriteLine($"O preço final do produto é: {totalCmDesconto}");

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);//Math.Pow é potencia
            Console.WriteLine($"IMC é {imc}.");

            //Numero Par/Impar
            int par = 24;
            double impar = 55;
            Console.WriteLine($"{par}/2 tem resto {par % 2}");//% é o resto da divisão
            Console.WriteLine($"{impar}/2 tem resto {impar % 2}");

        }
    }
}
