using System.Security.Cryptography.X509Certificates;
using Refactory.DesignPatterns.Strategy.SwitchStatement;
using Refactory.DesignPatterns.Strategy.SwitchStatement.Bad;
using Refactory.DesignPatterns.Strategy.SwitchStatement.Good.Models.RoomShapes;

namespace RefactoryTests
{
    public class SwitchStatementTests
    {
        private GoodBadCode _code;

        [SetUp]
        public void Setup()
        {
            _code = new GoodBadCode();
        }

        [Test]
        public void TestGoodBadCode_Circle()
        {
            var radius = 5;
            var expectedValue = Math.Round(Math.PI * Math.Pow(radius, 2), 2);

            var badCodePrice = _code.CalculateCarpetPrice(1.0, Shape.Circle, 0, 0, radius, 0, 0, 0, 0);
            var goodCodePrice = _code.CalculateCarpetPrice(1.0, new Circle(radius));

            Assert.That(badCodePrice, Is.EqualTo(expectedValue));
            Assert.That(goodCodePrice, Is.EqualTo(expectedValue));
        }
        
        [Test]
        public void TestGoodBadCode_EquilateralTriangle()
        {
            var side = 5;
            var expectedValue = Math.Round(Math.Pow(side, 2) * (Math.Sqrt(3)/4), 2);

            var badCodePrice = _code.CalculateCarpetPrice(1.0, Shape.EquilateralTriangle, 0, 0, 0, side, 0, 0, 0);
            var goodCodePrice = _code.CalculateCarpetPrice(1.0, new EquilateralTriangle(side));

            Assert.That(badCodePrice, Is.EqualTo(expectedValue));
            Assert.That(goodCodePrice, Is.EqualTo(expectedValue));
        }

        [Test]
        public void TestGoodBadCode_Rectangle()
        {
            var length = 6.0;
            var width = 5.0;
            var expectedValue = Math.Round(length * width, 2);

            var badCodePrice = _code.CalculateCarpetPrice(1.0, Shape.Rectangle, length, width, 0, 0, 0, 0, 0);
            var goodCodePrice = _code.CalculateCarpetPrice(1.0, new Rectangle(length, width));

            Assert.That(badCodePrice, Is.EqualTo(expectedValue));
            Assert.That(goodCodePrice, Is.EqualTo(expectedValue));
        }

        [Test]
        public void TestGoodBadCode_Trapezium()
        {
            var a = 2.0;
            var b = 3.0;
            var height = 5.0;

            var expectedValue = Math.Round(height * ((a+b) / 2), 2);

            var badCodePrice = _code.CalculateCarpetPrice(1.0, Shape.Trapezium, 0, 0, 0, 0, a, b, height);
            var goodCodePrice = _code.CalculateCarpetPrice(1.0, new Trapezium(height, a, b));

            Assert.That(badCodePrice, Is.EqualTo(expectedValue));
            Assert.That(goodCodePrice, Is.EqualTo(expectedValue));
        }
    }
}