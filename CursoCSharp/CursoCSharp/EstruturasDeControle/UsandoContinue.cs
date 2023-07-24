namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine($"Números pares entre 1 e {intervalo}");

            for (int i = 1; i <= intervalo; i++)
            {
                if ( i % 2 == 1)
                {
                    continue;//O continue também é associado a switchs e a laços de repetição, então aqui ele faz com que o for continue até que falso
                }
                Console.Write(i + " ");
            }

            /*
            for (int i = 2; i <= intervalo; i+= 2)
            {
                Console.Write(i + " ");
            } Maneira certa de fazer uma apresentação de números pares 
            */
        }
    }
}
