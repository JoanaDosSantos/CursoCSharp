using System.Threading.Tasks.Sources;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".Insert(3, "World!").Replace("World!", "Mundo!");
            //Para casos de string, utilizando o ponto nós conseguimos acessar algumas funcionalidades disponíveis
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            //Em casos de string que tenham que ser inicializadas com um valor nulo, pode se usar a ? para uma navegação segura
            //pois nesse caso, o Legth traria a quantidade de caracteres, mas como a ? está presente, ele só irá trazer esse
            //dado caso a var tenha um valor.
        }
    }
}
