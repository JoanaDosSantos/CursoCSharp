namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";
            //As linhas acima faz o mesmo que:
            /*
             * if (entrada == "S" || entrada == "s")
             *  bomComportamento = true;
            */

            if (nota >= 9.0 && bomComportamento) {//Caso o campo booleano tenha que ser true, não é necessário que seja inserido 
                Console.WriteLine("Quadro de honra!");// bomComportamento == True, pq ele automaticamente valida esse valor
                //E caso false bomComportamento == false NAO!! O certo é !bomComportamento
            }


        }
    }
}
