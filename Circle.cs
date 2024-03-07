using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Circle : Shape
{

    private double Radius{ get; set; }

    public override double Area { get => Math.PI * Math.Pow(Radius, 2); }
    public override double Perimeter { get => 2 * Math.PI * Radius; }

    public Circle(double _Radius)
    {
        Radius = _Radius;
    }
}