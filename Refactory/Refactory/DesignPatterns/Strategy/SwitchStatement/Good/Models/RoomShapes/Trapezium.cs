using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory.DesignPatterns.Strategy.SwitchStatement.Good.Models.RoomShapes
{
    public class Trapezium : IRoomShape
    {
        public Trapezium(double height, double a, double b)
        {
            Height = height;
            A = a;
            B = b;
        }

        private double Height { get; }
        private double A { get; }
        private double B { get; }
        public double Area() => Height * ((A + B) / 2);
    }
}
