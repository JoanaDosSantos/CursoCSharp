namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;//Esse é um exemplo de conversão implícita, aonde não há
            //perigo de perda de informações
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;//Esse processo aq é chamado de casting
            //Esse é um exemplo de conversão explicita
            //notaTruncada deve receber um valor inteiro. Porém, o valor dentro de nota é um double,
            //logo, ele pega o valor de nota, converte para o tipo de dentro dos parênteses e aí atribui.
            //Conversões aonde pode gerar uma perda de informações, é necessário que o casting seja realizado
            //Porém, quando não há riscos de perda de nenhum dado, essa conversão pode ser direta.
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.WriteLine("Digite sua idade:");
            string? idadeString = Console.ReadLine();//Até posso receber esse dado em formato string
            int idadeInteiro = int.Parse(idadeString);//Porém deve se atentar como esse será armazenado
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);//O Convert.ToInt32 vai converter esse valor pra inteiro
            Console.WriteLine($"Resultado: {idadeInteiro}");

            //Forma mais segura de string pra int
            Console.WriteLine("Digite o primeiro número: ");
            string palavra  = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); //Esse cara aq, vai tentar (try) converter o valor, se for algo
            //diferente do esperado, como uma palavra, ele retorna o valor padrão, 0
            Console.WriteLine($"Resultado 1: {numero}");

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2: {numero2}");//forma mais compacta de fazer o q tá encima
        }
    }
}
