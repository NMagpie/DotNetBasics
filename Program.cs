var rectangle1 = new Rectangle(3);

Console.WriteLine($"Rectangle area: {rectangle1.Area}, perimeter: {rectangle1.Perimeter}");

var circle1 = new Circle(4);

Console.WriteLine($"Circle area: {circle1.Area}, perimeter: {circle1.Perimeter}");

var triangle1 = new Triangle(4, 5, 6);

Console.WriteLine($"Triangle area: {triangle1.Area}, perimeter: {triangle1.Perimeter}");

triangle1.Dilate();

Console.WriteLine("Triangle was dilated by 2");

Console.WriteLine($"Triangle area: {triangle1.Area}, perimeter: {triangle1.Perimeter}");

rectangle1.Dilate(3.4);

Console.WriteLine("Rectangle was dilated by 3.4");

Console.WriteLine($"Rectangle area: {rectangle1.Area}, perimeter: {rectangle1.Perimeter}");