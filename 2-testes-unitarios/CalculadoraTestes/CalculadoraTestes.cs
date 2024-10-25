using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    //metodo de teste:
    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //arrange
        int num1 = 5;
        int num2 = 10;

        //act
        int resultado = _calc.Somar(num1, num2);

        //assert
        Assert.Equal(15, resultado);
    }


    [Fact]
    public void DeveSomar10com10ERetornar20()
    {
        //arrange
        int num1 = 10;
        int num2 = 10;

        //act
        int resultado = _calc.Somar(num1, num2);

        //assert
        Assert.Equal(20, resultado);
    }
}