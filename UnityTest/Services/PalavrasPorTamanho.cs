namespace UnityTest.Services
{
    public class PalavrasPorTamanho
    {
        public List<string> SelecionarPalavras(List<string> palavras)
        {
            return palavras.Where(p => p.Length > 9).ToList();
        }
    }
}
