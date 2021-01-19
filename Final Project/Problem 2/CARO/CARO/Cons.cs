using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO
{
    public class Cons
    {
        //chiều rộng chiều dài của các ô trong bàn cờ (button)
        //cho button là 1 hình vuông
        public static int CHESS_WIDTH = 30;    //chiều rộng button
        public static int CHESS_HEIGHT = 30;    //chiều cao button
        //chiều rộng chiều dài của bàn cờ 
        public static int CHESS_BOARD_WIDTH = 26;           
        public static int CHESS_BOARD_HEIGHT = 21;

        //Thời Gian Chạy 
        public static int Cool_Down_STEP = 10;
        //Thời Gian Giới Hạn
        public static int Cool_Down_Time = 1000;
        //Thời gian procces bar tăng lên 1 lần
        public static int Cool_Down_Interval = 100;
    }
}
