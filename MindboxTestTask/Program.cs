using MindboxTestTask.Library;

namespace MindboxTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IArea[] areas =
            {
                new Circle(5),
                new Circle(2),
                new Circle(8),
                new Circle(10),
                new Triangle(5, 5, 6),
                new Triangle(2, 2, 3),
                new Triangle(4, 6, 4),
                new Triangle(3, 5, 3)
            };

            foreach (var area in areas)
            {
                Console.WriteLine(area.CalculateArea());
            }
        }
    }
}