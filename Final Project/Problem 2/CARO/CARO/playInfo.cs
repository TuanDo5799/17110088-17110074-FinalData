using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO
{
    class playInfo
    {
        private Point point;
        public Point Point { get => point; set => point = value; }
        private int currentPlayer;
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public playInfo(Point point,int currentplayer)
        {
            this.Point = point;
            this.CurrentPlayer = currentplayer;
        }   
    }
}
