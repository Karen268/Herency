namespace Herency01;

public class Circle:GeometricFigure
{
    private double _r;

    // properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Constructor
    public Circle(string name, double r):base(name)
    {
        R= r;
    }
    //Methods
    public override double GetArea()=> Math.PI * Math.Pow(R, 2);


    public override double GetPerimeter() => 2 * Math.PI * R;
   
    private double ValidateR(double r)
    {
        if (r < 0)
        {
            throw new ArgumentException("The radius is incorrect");
        }
        return r;
    
    }
}
