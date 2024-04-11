namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Main
            while (true)
            {


                JogoForca novoJogo = new JogoForca();
                
                novoJogo.geradorPalavra();
                novoJogo.MostrarLetra();

                if (jogarNovamente()) break;

            }

            #endregion
        }
        #region Métodos
        public static bool jogarNovamente()
        {
            Console.WriteLine("Deseja Continuar? (S / N)");
            string resposta = Console.ReadLine().ToUpper();
            Console.Clear();
            return resposta == "N";


        }

        public static T obterValor<T>(string texto)
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
