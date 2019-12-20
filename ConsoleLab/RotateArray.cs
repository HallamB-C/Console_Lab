using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class RotateArray
    {
        public int[] DoThing(int[] A, int K)
        {
            if (K <= 0 || A.Length == 0)
            {
                return A;
            }
            else
            {
                int[] nA = new int[A.Length];
                nA[0] = A[A.Length - 1];
                for (int i = 0; i < A.Length - 1; i++)
                {
                    nA[i + 1] = A[i];
                }
                return DoThing(nA, K - 1);
            }
        }
    }
}
