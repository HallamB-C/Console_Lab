using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class OddArrayItem
    {
        public int DoThing(int[] A)
        {
            // returns unique element in the arry A

            // Wizardy using XOR
            //int result = 0;
            //foreach (var i in A)
            //    result ^= i;
            //return result;

            if (A.Length == 1)
            {
                return A[0];
            }
            Array.Sort(A);
            for (int i = 0; i < A.Length; i += 2)
            {
                if (A[i] != A[i + 1])
                {
                    return A[i];
                }
            }
            return -1;
        }
    }
}
