using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory.DesignPatterns.Strategy.SwitchStatement.Good.Models.RoomShapes
{
    public class Rectangle : IRoomShape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        private double Length { get; }
        private double Width { get; }

        public double Area() => Length * Width;
    }
}
