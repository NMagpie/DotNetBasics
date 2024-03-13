using System.Collections;


internal abstract class Shape : ICloneable
{
    public abstract double Area { get; }
    public abstract double Perimeter { get; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public abstract void Dilate(double times);

    public abstract void Dilate();
}