using System.Collections;

internal class Shapes : IEnumerable
{

    private readonly Shape[] _shapes;

    public Shapes(Shape[] shapes)
    {
        _shapes = new Shape[shapes.Length];

        for (int i = 0; i < shapes.Length; i++)
        {
            _shapes[i] = shapes[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }

    public ShapesEnum GetEnumerator()
    {
        return new ShapesEnum(_shapes);
    }
}