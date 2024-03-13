var shapes = new Shapes([new Rectangle(3), new Circle(4), new Triangle(4, 5, 6)]);

foreach (var shape in shapes)
{
    Console.WriteLine($"{GetShapeName(shape)} area: {shape.Area}, perimeter: {shape.Perimeter}");
}

string GetShapeName(Shape shape) =>
/*    shape.GetType().Name;*/
/*    shape switch
    {
        Triangle => "Triangle",
        Rectangle => "Rectangle",
        Circle => "Circle",
        _ => "Unknown Shape"
    };*/
    shape is Triangle ? "Triangle" : shape is Rectangle ? "Rectangle" : shape is Circle ? "Circle" : "Unknown Shape";