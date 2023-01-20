using Refactory.DesignPatterns.Behavioral.Strategy.SwitchStatement.Bad;
using Refactory.DesignPatterns.Behavioral.Strategy.SwitchStatement.Good.Models.RoomShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Refactory.DesignPatterns.Behavioral.Strategy.SwitchStatement
{
    public class GoodBadCode
    {

        public GoodBadCode()
        {
            Main();
        }

        private void Main()
        {
            //var area = CalculateCarpetPrice(10.0, Shape.Rectangle, 10)
        }

        public double CalculateCarpetPrice(double pricePerSqrMtr, Shape shape, double length, double width, double radius, double side, double a, double b, double height)
        {
            var area = 0.0;
            switch (shape)
            {
                case Shape.Rectangle:
                    area = length * width;
                    break;
                case Shape.Circle:
                    area = Math.PI * radius * radius;
                    break;
                case Shape.EquilateralTriangle:
                    area = side * side * (Math.Sqrt(3) / 4);
                    break;
                case Shape.Trapezium:
                    area = height * ((a + b) / 2);
                    break;
            }
            return Math.Round(area * pricePerSqrMtr, 2);
        }

        public double CalculateCarpetPrice(double pricePerSqrMtr, IRoomShape roomShape)
        {
            var area = roomShape.Area();
            return Math.Round(area * pricePerSqrMtr, 2);
        }
    }
}
