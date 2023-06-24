namespace CursoCSharp.Fundamentos
{
    class OperacoesDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;//Variável num1 recebe o valor 3
            num1 = 7;//Variável num1 substitui o valor 3 pelo 7
            num1 += 10;//Variável num1 recebe o valor dele mesmo + 10, mesmo q num1 = num1 + 10
            num1 -= 3;//num1 = num1 - 3
            num1 *= 5;//num1 = num1 * 5
            num1 /= 2;//num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 1;//Atribuição literal
            int b = a;//Atribuição por cópia

            a++;//a = a + 1, operador unário de incremento
            b--;//b = b - 1, operador unário de decremento

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Joana";
            dynamic d = c;//Atribuição por referência, onde o mesmo espaço de memória acessa esse indice
            d.nome = "João";//Mesmo que o mesmo seja alterado referenciando a var d, ele ainda está 
            //compartilhando o espaço da C, logo a mesma será alterada
        }
    }
}
