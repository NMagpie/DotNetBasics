﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Rectangle : Shape
{

    private double A { get; }

    private double B { get; }
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
}