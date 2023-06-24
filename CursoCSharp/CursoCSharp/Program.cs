using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operações Aritméticas - Fundamentos", OperacoesAritmeticas.Executar},
                {"Operações Relacionais - Fundamentos", OperacoesRelacionais.Executar},
                {"Operações Lógicos - Fundamentos", OperacoesLogicos.Executar},
                {"Operações de Atribuição - Fundamentos", OperacoesDeAtribuicao.Executar},
                {"Operações de Unários - Fundamentos", OperacoesDeUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
            });

            central.SelecionarEExecutar();

        }
    }
}