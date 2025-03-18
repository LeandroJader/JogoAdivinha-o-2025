namespace JogoAdivinhação.ConsoleApp
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
                else if (tentativa == totalDeTentativas)
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
                    Console.WriteLine("O número secreto é menor que o número digitado.");
                    Console.WriteLine("========================================");
                }
                else
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("O número secreto é maior que o número digitado.");
                    Console.WriteLine("========================================");
                }

                Console.WriteLine("Aperte ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}
