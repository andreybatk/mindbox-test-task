using MindboxTestTask.Library;

namespace MindboxTestTask.NTests
{
    public class CircleAndTriangleTests
    {
        [Test]
        public void CreateTriangle_TriangleInvalid_ShouldThrowArgumentException([Random(-100, 0, 5)] double sideA, [Random(-100, 0, 5)] double sideB, [Random(-100, 0, 5)] double sideC)
        {
            //act
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));

            //assert
            Assert.That(exception.Message, Is.EqualTo($"{nameof(sideA)}, {nameof(sideB)}, {nameof(sideC)} should be positive!")); ;
        }
        [Test]
        public void CreateCircle_CircleInvalid_ShouldThrowArgumentException([Random(-100, 0, 5)] double radius)
        {
            //act
            var exception = Assert.Throws<ArgumentException>(() => new Circle(radius));

            //assert
            Assert.That(exception.Message, Is.EqualTo($"{nameof(radius)} should be positive!"));
        }
        [Test]
        public void Triangle_CircleIsValid_ShouldCalculateArea([Random(1, 1000, 5)] double sideA, [Random(1, 1000, 5)] double sideB, [Random(1, 1000, 5)] double sideC)
        {
            //arrange
            var p = (sideA + sideB + sideC) / 2;
            var expectedResult = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            Triangle circle = new Triangle(sideA, sideB, sideC);

            //act
            var result = circle.CalculateArea();

            //assert
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        public void Circle_CircleIsValid_ShouldCalculateArea([Random(1, 1000, 5)] double radius)
        {
            //arrange
            var expectedResult = Math.PI * Math.Pow(radius, 2);
            Circle circle = new Circle(radius);

            //act
            var result = circle.CalculateArea();

            //assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}