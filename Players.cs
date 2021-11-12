using System;
using System.Collections.Generic;
using System.Text;


namespace Sabroso_CheckPoint3
{

    class Player
    {
        private string playerN;
        private int point;
        private int rebound;
        private int assist;

        public int compare;
        public string GetName
        {
            get 
            {
                return playerN;  
            }
            set 
            {  
                playerN = value; 
            }
        }

        public int GetPoints
        {
            get 
            { 
                return point; 
            }
            set 
            { 
                point = value; 
            }
        }

        public int GetRebounds
        {
            get 
            { 
                return rebound; 
            }
            set 
            { 
                rebound = value; 
            }
        }

        public int GetAssists
        {
            get 
            { 
                return assist; 
            }
            set 
            { 
                assist = value; 
            }
        }

        public Player()
        {
            playerN = " ";
            point = -1;
            rebound = -1;
            assist = -1;
        }

        public Player(string playerN, int point, int rebound, int assist)
        {
            this.playerN = playerN;
            this.point = point;
            this.rebound = rebound;
            this.assist = assist;
        }
        public int HasMorePoints(int compPoints)
        {
            if (point > compPoints)
            {
                compare = 1;
            }
            else if (point < compPoints)
            {
                compare = 2;
            }
            else if (point == compPoints)
            {
                compare = 3;
            }
            return compare;
        }

        public int HasMoreRebounds(int compRebounds)
        {
            if (rebound > compRebounds)
            {
                compare = 1;
            }
            else if (rebound < compRebounds)
            {
                compare = 2;
            }
            else if (rebound == compRebounds)
            {
                compare = 3;
            }
            return compare;
        }

        public int HasMoreAssists(int compAssists)
        {
            if (assist > compAssists)
            {
                compare = 1;
            }
            else if (assist < compAssists)
            {
                compare = 2;
            }
            else if (assist == compAssists)
            {
                compare = 3;
            }
            return compare;
        }
    }
}

