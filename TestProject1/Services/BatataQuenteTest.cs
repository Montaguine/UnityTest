using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityTest.Services;

namespace TestProject1.Services
{
    public class BatataQuenteTest
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
    }
}
