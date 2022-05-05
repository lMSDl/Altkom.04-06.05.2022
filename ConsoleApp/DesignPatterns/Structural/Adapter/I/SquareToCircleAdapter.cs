using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DesignPatterns.Structural.Adapter.I
{
    public class SquareToCircleAdapter : ICircle
    {
        private Square _square;

        public SquareToCircleAdapter(Square square)
        {
            _square = square;
        }

        public double Radius => Math.Sqrt(2) * _square.Width / 2.0;
    }
}
