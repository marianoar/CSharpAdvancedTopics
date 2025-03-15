// See https://aka.ms/new-console-template for more information

internal class Calculator
{
    public Calculator()
    {
    }

    internal float Divide(int v1, int v2)
    {
        throw new DivideByZeroException();
        return (float)v1 / (float)v2;
    }
}