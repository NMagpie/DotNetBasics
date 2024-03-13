using System;
using System.Collections;

internal class ShapesEnum : IEnumerator
{
    public Shape[] _shapes;

    int position = -1;

    public ShapesEnum(Shape[] list)
    {
        _shapes = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _shapes.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Shape Current
    {
        get
        {
            try
            {
                return _shapes[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}