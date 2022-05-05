using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.I
{
    public class SquareToCircleConverter
    {
        public Circle Convert(Square square)
        {
            return new Circle() { Radius = new SquareToCircleAdapter(square).Radius };
        }
    }
}
