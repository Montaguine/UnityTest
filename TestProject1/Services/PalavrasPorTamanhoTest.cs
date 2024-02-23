using UnityTest.Services;

namespace TestProject1.Services
{
    public class PalavrasPorTamanhoTest
    {
        [Fact]
        public void Test1()
        {
            var palavrasPorTamanho = new PalavrasPorTamanho();

            var result = palavrasPorTamanho.SelecionarPalavras(new List<string>            
            { 
                "Idiossincrasia", 
                "Ambivalente", 
                "Quimérica", 
                "Perpendicular", 
                "Efêmero", 
                "Pletora", "Obnubilado", "Xilografia", "Quixote", "Inefável" 
            });

            var expected_Result = new[]
            {
                "Idiossincrasia",
                "Ambivalente",
                "Perpendicular",
                "Obnubilado",
                "Xilografia"
            };

            Assert.Equal(expected_Result, result);
        }

        [Fact]
        public void Test2()
        {
            // _sut;
            var palavrasPorTamanho = new PalavrasPorTamanho();

            var result = palavrasPorTamanho.SelecionarPalavras(new List<string> { "Idiossincrasia", "Ambivalente", "Quimérica", "Perpendicular", "Efêmero", "Pletora", "Obnubilado", "Xilografia", "Quixote", "Inefável" });

            var expected_Result = new[]
            {
                "Idiossincrasia",
                "Ambivalente",
                "Perpendicular",
                "Obnubilado",
                "Xilografia"
            };

            Assert.Equal(expected_Result, result);
        }
    }
}