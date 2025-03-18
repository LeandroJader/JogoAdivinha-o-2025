namespace JogoAdivinha��o.ConsoleApp
{
    public class FuncoesJogo
    {

        public static int GerarNumerosAleatorios()
        {
            Random geradorDeNumeros = new Random();
            return geradorDeNumeros.Next(1, 21);
        }


        public void LoopTentativas(int totalDeTentativas, int numeroSecreto)
        {
            for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                Console.WriteLine("========================================");

                // L�gica do jogo
                Console.Write("Digite um n�mero entre 1 e 20: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == numeroSecreto)
                {
                    Console.WriteLine("========================================");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parab�ns! Voc� acertou!");
                    Console.ResetColor();
                    Console.WriteLine("========================================");
                    break;
                }
                else if (tentativa == totalDeTentativas)
                {
                    Console.WriteLine("========================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Que pena! Voc� usou todas as tentativas. O n�mero era {numeroSecreto}.");
                    Console.ResetColor();
                    Console.WriteLine("========================================");
                    break;
                }
                else if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("O n�mero secreto � menor que o n�mero digitado.");
                    Console.WriteLine("========================================");
                }
                else
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("O n�mero secreto � maior que o n�mero digitado.");
                    Console.WriteLine("========================================");
                }

                Console.WriteLine("Aperte ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}
