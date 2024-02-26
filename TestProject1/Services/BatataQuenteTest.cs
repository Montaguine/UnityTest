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
        [Theory]
        [InlineData(-3)]
        [InlineData(-10)]
        [InlineData(-1)]
        [InlineData(-5000)]
        public void Verificar_se_lanca_excecao_com_quantidade_de_jogadores_negativa(int numeroDeJogadores)
        {
            var _sut = new HotPotatoGameService();

            Assert.Throws<ArgumentException>(() => _sut.PlayHotPotato(numeroDeJogadores));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void Verificar_numero_de_jogadores_invalido(int jogadores)
        {
            var _sut = new HotPotatoGameService();

            Assert.Throws<ArgumentException>(() => _sut.PlayHotPotato(jogadores));
        }
    }
}
