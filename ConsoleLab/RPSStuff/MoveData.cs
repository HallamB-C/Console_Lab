using System;
using System.Collections.Generic;
using System.Text;

namespace RPSMatrix
{
    class MoveData
    {
        public String PlayerMove { get; set; }
        public String CompMove { get; set; }
        public double WinRate { get; set; }

        public MoveData(string pM, string cM, double wR)
        {
            this.PlayerMove = pM;
            this.CompMove = cM;
            this.WinRate = wR;
        }
    }
}
