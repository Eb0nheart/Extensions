namespace ExtensionsTests.Mathematics;

public class Multiplication
{

    [Test]
    [TestCase(1)]
    [TestCase(5)]
    [TestCase(100)]
    [TestCase(173781263)]
    public void Multiply_int_works(int multiplier)
    {
        var baseNumber = 5;
        var expectedResult = baseNumber * multiplier;

        var result = baseNumber.MultiplyBy(multiplier);

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    [TestCase(1.3)]
    [TestCase(5.8)]
    [TestCase(100.4)]
    [TestCase(173781263.7)]
    public void Multiply_double_works(int multiplier)
    {
        var baseNumber = 5;
        var expectedResult = baseNumber * multiplier;

        var result = baseNumber.MultiplyBy(multiplier);

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    [TestCase("0.00276234m")]
    [TestCase("0.1872m")]
    [TestCase("1.1722m")]
    [TestCase("1.0182372m")]
    public void Multiply_decimal_works(decimal multiplier)
    {
        var baseNumber = 5;
        var expectedResult = baseNumber * multiplier;

        var result = baseNumber.MultiplyBy(multiplier);

        Assert.AreEqual(expectedResult, result);
    }
}