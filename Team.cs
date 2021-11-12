using System;
using System.Collections.Generic;
using System.Text;

namespace Sabroso_CheckPoint3
{
    class Team
    {
        private int total;

        public Team()
        {
            total = 0;
        }

        public int ComputeTotal(int player1, int player2, int player3, int player4, int player5)
        {
            total = player1 + player2 + player3 + player4 + player5;
            return total;
        }
    }
}
