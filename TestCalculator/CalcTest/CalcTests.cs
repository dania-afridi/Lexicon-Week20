using System;
using Xunit;
using TestCalculator;

public class CalcTests
{
    private readonly Calc _calc = new Calc();
    
    //------------------ Tests For Addition ---------------------//
    [Theory]
    [InlineData(new double[] {3, 9, 2}, 14)]
    [InlineData(new double[] { -1, -3, -5 }, -9)]
    [InlineData(new double[] { 3.1, 2.2, 4.2 }, 9.5)]
    public void add_returnCorrectSum(double[] numbers, double expected)
    {
        double sum = _calc.add(numbers);
        Assert.Equal(expected, sum);
    }

    //------------------ Tests For Subtraction ---------------------//
    [Theory]
    [InlineData(new double[] { 3, 9, 2 }, -8)]
    [InlineData(new double[] { -1, -3, -5 }, 7)]
    [InlineData(new double[] { 3.1, 2.2, 4.2 }, -3.3)]
    public void subtract_returnCorrectDifference(double[] numbers, double expected)
    {
        double difference = _calc.subtract(numbers);
        Assert.Equal(expected, difference);
    }

    //------------------ Tests For Multiplication ---------------------//
    [Theory]
    [InlineData(3, 6, 18)]
    [InlineData(-1, -3, 3)]
    [InlineData(3.1, 2.2, 6.82)]
    public void multiply_returnCorrectProduct(double num1, double num2, double expected)
    {
        double product = _calc.multiply(num1, num2);
        Assert.Equal(expected, product);
    }

    //------------------ Tests For Division ---------------------//
    [Theory]
    [InlineData(3, 6, 18)]
    [InlineData(-1, -3, 3)]
    [InlineData(3.1, 2.2, 6.82)]
    public void divide_returnCorrectQuotient(double num1, double num2, double expected)
    {
        double quotient = _calc.divide(num1, num2);
        Assert.Equal(expected, quotient);
    }

    [Fact]
    public void division_by_Zero_throwException()
    {
        Assert.Throws<DivideByZeroException>( () => _calc.divide(12, 0) );
    }

}