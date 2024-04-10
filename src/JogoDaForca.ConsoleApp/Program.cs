namespace JogoDaForca.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region Main
            while (true)
            {


                Palavra novoJogo = new Palavra();
                novoJogo.geradorPalavra(out novoJogo.palavraSelecionada, out novoJogo.palavraMascarada);
                novoJogo.mostraLetra(novoJogo.palavraSelecionada, novoJogo.palavraMascarada, ref novoJogo.tentativas);

                if (jogarNovamente()) break;

            }

            #endregion
        }
        #region Métodos
        static bool jogarNovamente()
        {
            Console.WriteLine("Deseja Continuar? (S / N)");
            string resposta = Console.ReadLine().ToUpper();
            Console.Clear();
            return resposta == "N";


        }

        static T obterValor<T>(string texto)
        {
            Console.WriteLine(texto);
            string input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido!");
                return obterValor<T>(texto);
            }
        }

        #endregion
    }
}
