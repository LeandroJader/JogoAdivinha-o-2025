
namespace JogoAdivinhação.consoleapp
{
    public class Funcoesjogo
    {
        public static int GerarNumerosAleatorios()
        {
            // Geração de número secreto
            Random geradorDeNumeros = new Random();

            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            return numeroSecreto;
        }

       



    }
}
