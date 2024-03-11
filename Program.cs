var shapes = new Shapes();

shapes.AddElement(new Rectangle(3));

shapes.AddElement(new Circle(4));

shapes.AddElement(new Triangle(4, 5 ,6));

shapes.MoveNext();

Console.WriteLine($"Rectangle area: {shapes.Current?.Area}, perimeter: {shapes.Current?.Perimeter}");

shapes.MoveNext();

Console.WriteLine($"Circle area: {shapes.Current?.Area}, perimeter: {shapes.Current?.Perimeter}");

shapes.MoveNext();

Console.WriteLine($"Triangle area: {shapes.Current?.Area}, perimeter: {shapes.Current?.Perimeter}\n");

shapes.Current?.Dilate();

Console.WriteLine("Triangle was dilated by 2");

Console.WriteLine($"Triangle area: {shapes.Current?.Area}, perimeter: {shapes.Current?.Perimeter}\n");

shapes.Reset();

shapes.MoveNext();

shapes.Current?.Dilate(3.4);

Console.WriteLine("Rectangle was dilated by 3.4");

Console.WriteLine($"Rectangle area: {shapes.Current?.Area}, perimeter: {shapes.Current?.Perimeter}");