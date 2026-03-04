namespace Herency01;

public class Trapeze : Triangle
{
    private double _d;

    //Properties

    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    //Constructors
    public Trapeze(string name, double a, double b, double c,double h, double d) : base(name, a, b, c, h)
    {
        D = d;
    }

    //Methods

    public override double GetArea() => ((A + B) * D) / 2;

    public override double GetPerimeter() => A + B + C + D;
    private double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new ArgumentException("The diagonal D of the Trapeze is incorrect");
        }
        return d;
    }
}


