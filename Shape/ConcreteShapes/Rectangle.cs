internal class Rectangle : Shape
{
    public double A { get; set; }

    public double B { get; set; }

    public override double Area => A * B;
    public override double Perimeter => 2 * (A + B);

    public Rectangle(double a)
    {
        A = B = a;
    }

    public Rectangle(double a, double b)
    {
        A = a;
        B = b;
    }

    public override void Dilate(double times)
    {
        A *= times;
        B *= times;
    }

    public override void Dilate()
    {
        A *= 2;
        B *= 2;
    }
}