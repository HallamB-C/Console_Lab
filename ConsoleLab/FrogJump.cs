using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class FrogJump
    {
        public int solution(int X, int Y, int D)
        {
            Y -= X;
            double r = (double)Y / (double)D;
            return (int)Math.Ceiling(r);
        }
    }
}
