namespace JogoAdivinhação.consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            while (true)
            {
                ExibitMenu();

                string opcaoDificuldade = EscolhaDificuldade();


                int totalDeTentativas = 0;


                if (DificuldadeFacilEscolhida(opcaoDificuldade))
                    totalDeTentativas = 10;

                else if (DificuldadeNormalEscolhida(opcaoDificuldade))
                    totalDeTentativas = 5;

                else if (DificuldadeDificil(opcaoDificuldade))
                    totalDeTentativas = 3;

                int numeroSecreto=Funcoesjogo.GerarNumerosAleatorios();



                // Loop de tentativas do jogo
                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                    Console.WriteLine("========================================");

                    // Lógica do jogo
                    Console.Write("Digite um número entre 1 e 20: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("========================================");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Parabéns! Você acertou!");
                        Console.ResetColor();
                        Console.WriteLine("========================================");

                        break;
                    }

                    if (tentativa == totalDeTentativas)
                    {
                        Console.WriteLine("========================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Que pena! Você usou todas as tentativas. O número era {numeroSecreto}.");
                        Console.ResetColor();
                        Console.WriteLine("========================================");

                        break;
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("O numero secreto e menor que o numero digitado.");
                        Console.WriteLine("========================================");
                    }
                    else
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("o numero secreto e maior que o numero digitado.");
                        Console.WriteLine("========================================");
                    }

                    Console.WriteLine("Aperte ENTER para continuar...");
                    Console.ReadLine();
                }

                Console.Write("Deseja continuar (S/N)? ");

                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }

        }
        static void ExibitMenu()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jogo de Adivinhação");
            Console.ResetColor();
            Console.WriteLine("========================================");

        }
        static string EscolhaDificuldade()
        {

            Console.WriteLine("Escolha um nível de dificuldade:");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Normal (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.WriteLine("========================================");
            Console.Write("Digite sua escolha: ");
            string opcaoDificuldade = Console.ReadLine();
            return opcaoDificuldade;

        }
        static bool DificuldadeFacilEscolhida(string dificuldade)
        {
            bool DificuldadeFacilEscolhida = dificuldade == "1";

            return DificuldadeFacilEscolhida;
        }
        static bool DificuldadeNormalEscolhida(string Dificuldade)
        {

            bool DificuldadeMediaEscolhida = Dificuldade == "2";
            return DificuldadeMediaEscolhida;
        }
        static bool DificuldadeDificil(string dificuldade)
        {
            bool DificuldadeDificil = dificuldade == "3";
            return DificuldadeDificil;


        }
    }
}
