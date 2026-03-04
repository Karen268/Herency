namespace Herency01;

public class Rectangle:Square
{
    private double _b;

    //Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    // Constructors
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    // Methods
    public override double GetArea() => A * B;

    public override double GetPerimeter() => 2 * (A + B);
    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("The area of Rectangle is incorrect");
        }
        return b;
    }
}
