using System.ComponentModel;
using System.Runtime.CompilerServices;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTest
{
    private CalculadoraImp _calc;

    public CalculadoraTest()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10Retornar15()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado); // Primeiro passar o valor esperado e depois o valor atual
    }

    [Fact]
    public void DeveSomar10Com10Retornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado); // Primeiro passar o valor esperado e depois o valor atual
    }

    [Fact]
    public void DeveSubtrair10Com5Retornar5()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(5, resultado); // Primeiro passar o valor esperado e depois o valor atual
    }

    [Fact]
    public void DeveDividir10Com5Retornar2()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(2, resultado); // Primeiro passar o valor esperado e depois o valor atual
    }

    [Fact]
    public void DeveMultiplicar10Com5Retornar50()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(50, resultado); // Primeiro passar o valor esperado e depois o valor atual
    }

    [Fact]
    public void DeveVerificarSeONumero64EhParRetornarTrue()
    {
        // Arrange
        int num = 64;

        // Act
        bool resultado = _calc.EhPar(num);

        // Assert
        Assert.True(resultado); // Primeiro passar o valor esperado e depois o valor atual
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 8, 64 })]
    public void DeveVerificarSeOsNumerosSaoParesRetornarTrue(int[] numeros)
    {
        // Act & Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}