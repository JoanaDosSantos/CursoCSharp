namespace CursoCSharp.ClassesEMetodos
{

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro() { }
    }

    public class Construtores
    {
        public static void Executar()
        {
            //Forma 1: caso nao haja um construtor na classe
            var carro1 = new Carro();//Construtor padrão
            carro1.Fabricante = "BMW";//Ele só é utilizado quando nao há um construtor que receba
            carro1.Modelo = "325i";//os valores "duros" e obrigatórios junto a classe (no caso o Carro 1)
            carro1.Ano = 2017;//Se houver o contrutor na classe, ele deve ser utilizado como mostrado na
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");//linha 29

            //Forma 2: caso haja um constutor
            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine(carro2);

            //Forma 3
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2009
            };
            Console.WriteLine(carro3);

        }
    }
}
/*
 * A escolha de qual construtor usar depende das necessidades específicas do seu programa. 
 * Se você quiser garantir que um objeto sempre seja criado com certos valores para seus campos, 
 * pode usar um construtor parametrizado que aceite argumentos para esses campos. Se o campo 
 * modelo fosse nulo, você ainda poderia usar qualquer um dos construtores. No construtor parametrizado, 
 * você poderia passar null como argumento para modelo. No construtor sem parâmetros, você simplesmente 
 * não definiria o campo modelo, deixando-o como null.
 */
