﻿using System.Collections;
using System.Reflection.Metadata.Ecma335;


internal class Shapes : IEnumerable<Shape>, IEnumerator<Shape>
{

    private ArrayList ShapeList = [];

    private int Index = -1;

    public void AddElement(Shape shape)
    {
        ShapeList.Add(shape);
    }

    public void RemoveElement(Shape shape)
    {
        ShapeList.Remove(shape);
    }

    public Shape? Current => (Index != -1 ? ShapeList[Index] : null) as Shape;

    object IEnumerator.Current => throw new NotImplementedException();

    public bool MoveNext()
    {
        if (Index < ShapeList.Count - 1)
        {
            Index++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        Index = -1;
    }

    public IEnumerator<Shape> GetEnumerator()
    {
        return (IEnumerator<Shape>)this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}