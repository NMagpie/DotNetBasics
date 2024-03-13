internal class Triangle : Shape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public override double Area {
        get 
        {
            var semiPerimeter = Perimeter / 2;

            return Math.Sqrt(semiPerimeter * ( semiPerimeter - A ) * ( semiPerimeter - B ) * ( semiPerimeter - C ));
        } 
    }
    public override double Perimeter => A + B + C;

    public Triangle(double a)
    {
        A = B = C = a;
    }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override void Dilate(double times)
    {
        A *= times;
        B *= times;
        C *= times;
    }

    public override void Dilate()
    {
        A *= 2;
        B *= 2;
        C *= 2;
    }
}