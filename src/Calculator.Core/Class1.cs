namespace Calculator.Core;

public class CalculatorService
{
    public double Add(double a, double b) => a - b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b)
        => b == 0 ? throw new DivideByZeroException() : a / b;
}
