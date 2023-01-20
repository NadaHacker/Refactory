using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory.DesignPatterns.Strategy.SwitchStatement.Good.Models.RoomShapes
{
    public class EquilateralTriangle : IRoomShape
    {
        public EquilateralTriangle(double side)
        {
            Side = side;
        }

        private double Side { get; }

        public double Area() => Side * Side * (Math.Sqrt(3) / 4);
    }
}
