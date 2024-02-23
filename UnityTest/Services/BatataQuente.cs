namespace UnityTest.Services
{
    public class BatataQuente
    {
        public class Jogador
        {
            public int numero;
            public Jogador(int num)
            {
                numero = num;
            }
        }
        static Random random = new Random();
        public List<Jogador> Jogar(int jogadores)
        {
            List<Jogador> lista = new List<Jogador>();
            List<Jogador> classificacao = new List<Jogador>();
            Queue<Jogador> fila = new Queue<Jogador>();

            for (int i = 0; i < jogadores; i++)
            {
                lista.Add(new Jogador(i + 1));
            }

//            lista = lista.OrderBy(x => random.Next()).ToList();

            foreach (var jogador in lista)
            {
                fila.Enqueue(jogador);
            }

            while (fila.Count > 1)
            {
                //int passes = random.Next(1, 101);
                int passes = 15;
                for (int i = passes; i >= 0; i--)
                {
                    if (i > 0)
                    {
                        Jogador passe = fila.Dequeue();
                        fila.Enqueue(passe);
                    }

                    if (i == 0)
                    {
                        Jogador eliminado = fila.Dequeue();
                        classificacao.Add(eliminado);
                    }
                }
            }
            classificacao.Add(fila.Dequeue());
            return classificacao;
        }
    }
}

