namespace Interface_DS_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes =
            {
                new Circle(10),
                new Circle(20),
                new Circle(30),
                new Rectangle(width_: 10, height_: 50),
                new Rectangle(width_: 33, height_: 20),
                new Rectangle(width_: 100, height_: 56),
                new Traingle(a: 5, b: 5, c: 7),
                new Traingle(a: 6, b: 8, c: 7),
                new Traingle(a: 8, b: 3, c: 7),
            };

            foreach (var item in shapes)
            {
                Console.WriteLine("Hello, i am {0}, my area is {1}, and my perimetr is {2}",
                    item.type, item.CalculateArea(), item.CalculatePerimetr());
            }

        }
    }
}
