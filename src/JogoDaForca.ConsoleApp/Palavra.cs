namespace JogoDaForca.ConsoleApp
{
    public class JogoForca
    {
        public string palavraSelecionada;
        public char[] palavraMascarada;
        public int tentativas = 0;

        public void MostrarLetra()
        {
            bool acertou;
            bool fimDeJogo = false;

            while (!fimDeJogo)
            {
                Console.WriteLine("Jogo da Forca | Academia de Programação!\n");
                geraForca(tentativas);

                Console.WriteLine($"\n\nA palavra escondida é: {string.Join(" ", palavraMascarada)}\n");
                char letraDigitada = Program.obterValor<char>("Digite uma letra: ").ToString().ToUpper()[0];

                acertou = false;

                for (int i = 0; i < palavraSelecionada.Length; i++)
                {
                    if (letraDigitada == palavraSelecionada[i])
                    {
                        palavraMascarada[i] = letraDigitada;
                        acertou = true;
                    }

                }

                Console.Clear();
                VerificarRespostaErrada(acertou, ref fimDeJogo);

            }

        }

        public void VerificarRespostaErrada(bool acertou, ref bool fimDeJogo)
        {
            if (!acertou)
            {
                tentativas++;
                if (tentativas >= 5)
                {
                    Console.WriteLine("Você perdeu! :(\n\n\n");
                    Console.WriteLine($"\t\t\tA palavra correta era {palavraSelecionada}\n\n");
                    fimDeJogo = true;
                }
            }
        }

        public void geradorPalavra()
        {
            Random randomizador = new Random();
            string[] palavras = {"ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI",
                        "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA",
                        "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA",
                        "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};

            int indicePalavraSelecionada = randomizador.Next(palavras.Length);
            palavraSelecionada = palavras[indicePalavraSelecionada];
            palavraMascarada = new string('_', palavraSelecionada.Length).ToCharArray();
        }

        public void geraForca(int tentativas)
        {
            switch (tentativas)
            {
                case 0:
                    Console.WriteLine("________\n |\t|\n |\t\n | \n | \n | \n_|___");
                    break;
                case 1:
                    Console.WriteLine("________\n |\t|\n |\tO\n |\t|\n | \n | \n_|___");
                    break;
                case 2:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\n | \n | \n_|___");
                    break;
                case 3:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\\\n | \n | \n_|___");
                    break;
                case 4:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\\\n |     / \n | \n_|___");
                    break;
                case 5:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\\\n |     / \\\n | \n_|___");
                    break;
                default:
                    break;
            }
        }

    }

}

