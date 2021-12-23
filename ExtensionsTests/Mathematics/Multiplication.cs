using Extensions.Mathematics;

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
    public void Multiply_double_works(double multiplier)
    {
        var baseNumber = 5.097;
        var expectedResult = baseNumber * multiplier;

        var result = baseNumber.MultiplyBy(multiplier);

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Multiply_decimal_works()
    {
        var baseNumber = 5.312m;
        var multiplier = 0.1872m;
        var expectedResult = baseNumber * multiplier;

        var result = baseNumber.MultiplyBy(multiplier);

        Assert.AreEqual(expectedResult, result);
    }
}