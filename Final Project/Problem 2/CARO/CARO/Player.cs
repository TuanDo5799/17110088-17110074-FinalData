using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO
{
   public  class Player
    {
        private string name;        //tên người chơi
        public string Name { get => name; set => name = value; }
        private int winGame;
        private int loseGame;
        private int step;
        public Image Team1 { get => Team; set => Team = value; }
        public int WinGame { get => winGame; set => winGame = value; }
        public int LoseGame { get => loseGame; set => loseGame = value; }
        public int Step { get => step; set => step = value; }

        //lưu lại hình hiển thị người chơi
        private Image Team;

        //hàm dựng
        public Player (string name, Image Team,int wingame,int losegame,int step)
        {
            this.name = name;
            this.Team = Team;
            this.WinGame = wingame;
            this.LoseGame = losegame;
            this.Step = step;
        }
    }
}
