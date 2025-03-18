namespace JogoAdivinha��o.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirMenu();

                string opcaoDificuldade = EscolherDificuldade();
                int totalDeTentativas = 0;

                if (DificuldadeFacilEscolhida(opcaoDificuldade))
                    totalDeTentativas = 10;
                else if (DificuldadeNormalEscolhida(opcaoDificuldade))
                    totalDeTentativas = 5;
                else if (DificuldadeDificilEscolhida(opcaoDificuldade))
                    totalDeTentativas = 3;


                int numeroSecreto = FuncoesJogo.GerarNumerosAleatorios();


                FuncoesJogo jogo = new FuncoesJogo();
                jogo.LoopTentativas(totalDeTentativas, numeroSecreto);


                Console.Write("Deseja continuar (S/N)? ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jogo de Adivinha��o");
            Console.ResetColor();
            Console.WriteLine("========================================");
        }

        static string EscolherDificuldade()
        {
            Console.WriteLine("Escolha um n�vel de dificuldade:");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - F�cil (10 tentativas)");
            Console.WriteLine("2 - Normal (5 tentativas)");
            Console.WriteLine("3 - Dif�cil (3 tentativas)");
            Console.WriteLine("========================================");
            Console.Write("Digite sua escolha: ");
            string opcaoDificuldade = Console.ReadLine();
            return opcaoDificuldade;
        }

        static bool DificuldadeFacilEscolhida(string dificuldade)
        {
            return dificuldade == "1";
        }

        static bool DificuldadeNormalEscolhida(string dificuldade)
        {
            return dificuldade == "2";
        }

        static bool DificuldadeDificilEscolhida(string dificuldade)
        {
            return dificuldade == "3";
        }
    }
}
