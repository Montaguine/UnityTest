using System.Text;

namespace UnityTest.Services
{
    public class HotPotatoGameService
    {
        static Random random = new Random();
        public string PlayHotPotato(int numberOfPlayers)
        {
            if (numberOfPlayers <= 1)
            {
                throw new ArgumentException("Deve haver pelo menos dois jogadores para jogar batata quente.");
            }

            Queue<int> playersQueue = new Queue<int>();
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                playersQueue.Enqueue(i);
            }

            for (int i = 0; i < 15; i++)
            {
                result.AppendLine($"Rodada {i + 1}, jogadores: {string.Join(", ", playersQueue)}");

                int currentPlayer = playersQueue.Dequeue();
                playersQueue.Enqueue(currentPlayer);
            }

            int explodedPlayer = playersQueue.Dequeue();

            result.AppendLine($"Jogador {explodedPlayer} explodiu.");

            return result.ToString();
        }
    }
}

