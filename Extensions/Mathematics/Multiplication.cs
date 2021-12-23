namespace Extensions.Mathematics;

public static class Multiplication
{
    public static int MultiplyBy(this int baseNumber, int multiplier)
        =>  baseNumber * multiplier;

    public static decimal MultiplyBy(this decimal baseNumber, decimal multiplier)
        => baseNumber * multiplier;

    public static double MultiplyBy(this double baseNumber, double multiplier)
        => baseNumber * multiplier;
}