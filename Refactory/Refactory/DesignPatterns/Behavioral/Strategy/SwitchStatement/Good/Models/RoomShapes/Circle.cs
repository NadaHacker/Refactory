using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory.DesignPatterns.Behavioral.Strategy.SwitchStatement.Good.Models.RoomShapes
{
    public class Circle : IRoomShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double Radius { get; }

        public double Area() => Math.PI * Radius * Radius;
    }
}
