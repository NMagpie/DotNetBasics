internal class Rectangle : Shape
{

    private double A { get; set; }

    private double B { get; set; }
    public override double Area { get => A * B; }
    public override double Perimeter { get => 2 * (A + B); }

    public Rectangle(double _A)
    {
        A = B = _A;

        // B = _A;
    }

    public Rectangle(double _A, double _B)
    {
        A = _A;
        B = _B;
    }

    public override void Dilate(double times)
    {
        this.A *= times;
        this.B *= times;
    }

    public override void Dilate()
    {
        this.A *= 2;
        this.B *= 2;
    }
}