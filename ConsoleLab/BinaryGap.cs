using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLab
{
    class BinaryGap
    {
        // Given int N will return the size of the longest chain of 0s in the ints binary form.
        public int solution(int N)
        {
            string binary = Convert.ToString(N, 2);
            int oCount = 0, nCount = 0;
            foreach (var b in binary)
            {
                if (b == '0' && oCount > 0)
                {
                    nCount++;
                }
                else if (b == '0')
                {
                    nCount = 1;
                }
                else
                {
                    nCount = 0;
                }
                if (nCount > oCount)
                {
                    oCount = nCount;
                }
            }
            Console.WriteLine($"For input {N}, Longest is {oCount}");
            return oCount;
        }
    }
}
