namespace GeometricShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quad q1 = new Quad(3,4,5,6);
            Quad q2 = new Quad(11,12,13,14);
            Rect r1 = new Rect(5, 10);
            Square s1 = new Square(6);

            Console.WriteLine($"Perimeter is {q1.Perimeter()}");
            Console.WriteLine($"Perimeter is {q2.Perimeter()}");
            Console.WriteLine($"Perimeter is {r1.Perimeter()} and the area is {r1.Area()}");
            Console.WriteLine($"Perimeter is {s1.Perimeter()} and the area is {s1.Area()}");
        }
    }
}
