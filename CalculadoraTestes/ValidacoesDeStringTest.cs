using Calculadora.Services.Strings;

namespace ValidacoesTest;
    public class ValidacoesDeStringTest
    {
        private ValidacoesDeString _validacoes;

        public ValidacoesDeStringTest()
        {
            _validacoes = new ValidacoesDeString();
        }

        [Fact]
        public void DeveContarAQuantidadeDeCaracteresDeHelloERetornar5()
        {
            // Arrange
            string texto = "Hello";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(5, resultado);
        }
    }