namespace Herency01;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    //Properties

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Constructors
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    //Methods

    public override double GetArea() => (B * H) / 2;

    public override double GetPerimeter() => A + B + C;

    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new ArgumentException("The side C of the Triangle is incorrect");
        }
        return c;
    }
    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height of the Triangle is incorrect");
        }
        return h;
    }
   
}
