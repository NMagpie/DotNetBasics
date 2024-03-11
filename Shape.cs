using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Perimeter { get; }

    public abstract void Dilate(double times);

    public abstract void Dilate();
}