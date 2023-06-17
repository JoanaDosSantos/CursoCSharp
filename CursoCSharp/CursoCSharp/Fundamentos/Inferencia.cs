namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            //Inferencia é quando vc declara uma variável sem tipo para usos temporários e elas "identificam" os seus tipos automaticamente
            var nome = "Joana";

            /* Para que a inferencia aconteça, se deve atribuir um valor na criação da variável, caso contrário ela dará erro pois
            variáveis de tipo implícito devem ser iniciadas

            Por exemplo:
                var idade;
                idade = 30;

            Para solucionar esse problema, ou se atribui um valor a variável, ou se inicia ela com seu tipo já atribuido */

            int a = 2;
            string b = "c";
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            string novaAlteracaoTeste = "Joana Santos";
            Console.WriteLine(novaAlteracaoTeste);
        }
    }
}
