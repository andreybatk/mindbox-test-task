namespace MindboxTestTask.Library
{
    public class Triangle : IArea
    {
        private double _sideA { get; set; }
        private double _sideB { get; set; }
        private double _sideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException($"{nameof(sideA)}, {nameof(sideB)}, {nameof(sideC)} should be positive!");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            if(IsRightTriangle())
            {
                Console.WriteLine("Triangle is rectangular!");
            }

            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
        private bool IsRightTriangle()
        {
            double maxSide = Math.Max(_sideA, Math.Max(_sideB, _sideC));
            double otherSide1, otherSide2;

            if (maxSide == _sideA)
            {
                otherSide1 = _sideB;
                otherSide2 = _sideC;
            }
            else if (maxSide == _sideB)
            {
                otherSide1 = _sideA;
                otherSide2 = _sideC;
            }
            else
            {
                otherSide1 = _sideA;
                otherSide2 = _sideB;
            }

            return Math.Pow(maxSide, 2) == Math.Pow(otherSide1, 2) + Math.Pow(otherSide2, 2);
        }
    }
}