using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class Hanoi
    {
        public void Move(int discs, Stack<int> fromPeg, Stack<int> toPeg, Stack<int> otherPeg)
        {

            if (discs == 1)
            {
                toPeg.Push(fromPeg.Pop());
                return;
            }
            Move(discs - 1, fromPeg, otherPeg, toPeg);

            toPeg.Push(fromPeg.Pop());

            Move(discs - 1, otherPeg, toPeg, fromPeg);
        }
    }
    // For main
    //Solution sol = new Solution();
    //Stack<int> fP = new Stack<int>(new[] { 3, 2, 1 });
    //Stack<int> tP = new Stack<int>();
    //Stack<int> oP = new Stack<int>();

    //sol.Move(3, fP, tP, oP);
}
