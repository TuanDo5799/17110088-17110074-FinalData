using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;

   

        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(panelchessboard, textboxPLname,pictureboxTeam,txtboxWingame,txtboxLoseGame,txtboxStep);   //hàm tạo bàn cờ TRUYỀN TỪ chessBOARDMANAGER
            //ủy thác hàm endgame
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.Teamed += ChessBoard_Teamed;

            prchcooldown.Step = Cons.Cool_Down_STEP;
            prchcooldown.Maximum = Cons.Cool_Down_Time;
            prchcooldown.Value = 0;     //giá trị ban đầu bằng 0

            //cai đặt cho timer
            TimeCoolD.Interval = Cons.Cool_Down_Interval;

            NewGame();

            

        }

        //hàm kết thúc game khi chạy hết processbar
        void EndGame()
        {
            TimeCoolD.Stop();       //kết thúc đếm thời gian khi người chơi ko đánh trong vòng 10s
            panelchessboard.Enabled = false;        //bàn cờ đóng lại khi người chơi bị xử thua
            undoToolStripMenuItem.Enabled = false;
            if (textboxPLname.Text == "Player 1")
            {
                MessageBox.Show("Game Over!! Player 2 won");
            }
            else if (textboxPLname.Text=="Player 2")
            {
                MessageBox.Show("Game Over!! Player 1 won");
            }
        }

        //hàm tạo lại trò chơi mới
        void NewGame()
        {
            prchcooldown.Value = 0;                 //thanh processbar chở về 0
            TimeCoolD.Stop();                       //thành processbar dừng khi newgame
            //xóa thanh processbar trước khi vẽ lại bàn cờ
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBoard();            //gọi lại hàm vẽ bàn cờ
        }
        
        //hàm trở lại 
        void Undo()
        {
            ChessBoard.Undo();
        }

        //hàm thoát trò chơi
        void Quit()
        {
          
            Application.Exit();
        }

        private void ChessBoard_Teamed(object sender, EventArgs e)
        {
            TimeCoolD.Start();          //bắt đầu chạy đếm thời gian từ lúc ng chơi bắt đầu chơi
            prchcooldown.Value = 0;     //bắt đầu từ 0
        }
        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }
        #endregion  // 
        #region Events
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panelchessboard_Paint(object sender, PaintEventArgs e)
        {

        }
        //
       
        private void TimeCoolD_Tick(object sender, EventArgs e)
        {
            //mỗi lần time tick thì thanh processbar chạy
            prchcooldown.PerformStep();

            //nếu chạy hết thanh mà ng chơi chưa chơi thì coi như xử thua
            if (prchcooldown.Value >= prchcooldown.Maximum)
            {             
                EndGame();              //gọi hàm endgame
            }
        }

        //new game
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }
        
        //quit khoi tro choi
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Are You Sure !!!", "Notice", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aBOUTGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Msg = "Caro game PvP" + Environment.NewLine + "Design by Team 3"
               + Environment.NewLine + "Ver 1.3";
            MessageBox.Show(Msg, "Caro game information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cHESSBOARDCOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
                panelchessboard.BackColor = dlgColor.Color;
        }

        private void cHESSCOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.FullOpen = true;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                ChessBoard.ChessBoard.BackColor = dlgColor.Color;
            }
        }
        #endregion
    }
}
