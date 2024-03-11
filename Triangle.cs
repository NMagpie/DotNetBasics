using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Triangle : Shape
{

    private double A { get; set; }

    private double B { get; set; }
    private double C { get; set; }
    public override double Area {
        get 
        {
            var semiPerimeter = Perimeter / 2;

            return Math.Sqrt(semiPerimeter * ( semiPerimeter - A ) * ( semiPerimeter - B ) * ( semiPerimeter - C ));
        } 
    }
    public override double Perimeter { get => A + B + C;}

    public Triangle(double _A)
    {
        A = B = C = _A;
        // B = _A;
        // C = _A;
    }

    public Triangle(double _A, double _B, double _C)
    {
        A = _A;
        B = _B;
        C = _C;
    }

    public override void Dilate(double times)
    {
        this.A *= times;
        this.B *= times;
        this.C *= times;
    }

    public override void Dilate()
    {
        this.A *= 2;
        this.B *= 2;
        this.C *= 2;
    }
}