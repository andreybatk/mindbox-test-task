namespace MindboxTestTask.Library
{
    public class Circle : IArea
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"{nameof(radius)} should be positive!");
            }

            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
