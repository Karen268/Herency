namespace Herency01;

public class Parallelogram : Rectangle
{
    private double _h;

    //Properties

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Constructors
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    //Methods

    public override double GetArea() => B * H;

    public override double GetPerimeter() => 2 * (A + B);
    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height of the parallelogram is incorrect");
        }
        return h;
    }
}
