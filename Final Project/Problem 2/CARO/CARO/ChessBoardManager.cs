using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO
{
    //quan li ban co caro
    public class ChessBoardManager
    {
        #region Properties 
        private Panel chessBoard;
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player1 { get => Player; set => Player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox Playername1 { get => Playername; set => Playername = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public PictureBox Team2 { get => this.Team; set => this.Team = value; }
        internal MyStack<playInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }
        public TextBox Wingame { get => wingame; set => wingame = value; }
        public TextBox Losegame { get => losegame; set => losegame = value; }
        public TextBox Step { get => step; set => step = value; }

        //tạo một mảng player 
        private List<Player> Player;
        //xác định người chơi nào đang chơi ( X or O)
        private int currentPlayer;
        //tên người chơi
        private TextBox Playername;
        //ảnh người chơi
        private PictureBox Team;
        //tính số trận thắng trận thua và các bước đi của từng người chơi
        private TextBox wingame;
        private TextBox losegame;
        private TextBox step;
        //xử dụng LIST để cử lí thắng thua
        private List<List<Button>> matrix;
        //khi thanh procesbar chạy hết time của ng choiw1  thì đến lượt người chơi 2
        private event EventHandler team;
        public event EventHandler Teamed
        {
            add
            {
                team += value;
            }
            remove
            {
                team -= value;
            }
        }

        //kết thúc toàn bộ trò chời khi thắng cuộc
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        private MyStack<playInfo> playTimeLine;
        #endregion

        #region Initialize
        public ChessBoardManager (Panel chessBoard, TextBox Playername, PictureBox Team,TextBox Wingame,TextBox LoseGame,TextBox Step)     //chuyền vào panel Chessboard,textbox,pictureboxTeam để vẽ 
        {
            this.ChessBoard = chessBoard;
            this.Playername = Playername;
            this.Team = Team;
            this.Wingame = Wingame;
            this.Losegame = LoseGame;
            this.Step = Step;
            this.Player = new List<Player>() {
                new Player("Player 1",Image.FromFile(Application.StartupPath + "\\Resources\\X.png"),0,0,0),      //người chơi 1 "X"
                new Player("Player 2",Image.FromFile(Application.StartupPath + "\\Resources\\0.png"),0,0,0),      //người chơi 2 "0"
            };   //khởi tạo player
          

        }

        #endregion

        /// <summary>
        /// Hàm vẽ ô cờ
        /// </summary>
        #region Methods
        public void DrawChessBoard()
        {
            //bàn cờ phải dc enable 
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();            //xóa bàn cờ cũ tạo bàn cờ mới khi newgame
            PlayTimeLine = new MyStack<playInfo>();
            //khởi tạo lại player
            currentPlayer = 0;
            Player[CurrentPlayer].Step = 0;
            Player[CurrentPlayer + 1].Step = 0;
            //sau khi vẽ xong mình gọi hàm changePlayer
            ChangePlayer();

            //lưu button vào Matrix
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y), //Point : Lấy từ Oldbutton lấy ra                                                                                                         
                        //Lấy tạo độ của button cũ cộng vào

                        BackgroundImageLayout = ImageLayout.Stretch,    //cho hình ảnh có chiều dài và rộng hợp với ô bàn cờ

                        Tag = i.ToString()  //dùng để xác định button nằm ở hàng nào để xứ lí thắng thua

                    };    //tạo button với chiều dài chiều dộng đã cho trước

                    //nhập click vào button
                    btn.Click += btn_Click;

                    //
                    ChessBoard.Controls.Add(btn);  //cho button vào bảng 

                    //thêm tất cả các button vào LIST
                    Matrix[i].Add(btn);

                    //
                    oldButton = btn;        //lưu lại ô cũ 
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Height = 0;       //trả về 0
                oldButton.Width = 0;
            }
        }

        //click in button
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //nếu player1 hay 2 đã nhập rồi thì player 1 hay 2 ko dc nhập lại ô đó
            if (btn.BackgroundImage != null)
                return;

            Team1(btn);
            Player[CurrentPlayer].Step++;
            PlayTimeLine.Push(new playInfo(GetChessPoint(btn),CurrentPlayer));
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();

            //thông báo người chơi before endgame
            if (team != null)
                team(this, new EventArgs());

            //kiểm tra trò chơi kết thúc hay chưa        
            if (IsEndGame(btn))
            {
                EndGame();
            }
           
        }

        //kết thúc trò chơi
        public void EndGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
                if (CurrentPlayer==1)
                {
                    Player[CurrentPlayer].LoseGame++;
                    Player[CurrentPlayer - 1].WinGame++;
                }
                else
                {
                    Player[CurrentPlayer].LoseGame++;
                    Player[CurrentPlayer + 1].WinGame++;
                }
               
            }
        }
        
        //hàm trả lại bước vừa đánh
        public bool Undo()
        {
            if (PlayTimeLine.Count() <= 0)
                return false;
            playInfo oldPoint = PlayTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
            btn.BackgroundImage = null;          
            if (PlayTimeLine.Count() <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = PlayTimeLine.Peek();
                CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }
            Player[CurrentPlayer].Step--;
            ChangePlayer();
            return true;
        }
       

        //Hàm để kiểm tra thắng hay thua
        private bool IsEndGame(Button btn)    //dựa vào button người chơi nhấn vô
        {
            return (IsEndHorizontal(btn) || IsEndVertical(btn) || IsEndPrimary(btn) || IsEndSub(btn));
        }
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal,vertical);
            return point;
        }

        private bool IsEndHorizontal(Button btn)    //kiểm tra hàng ngang
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for (int i=point.X;i>=0;i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else break;
            }
            int countRight = 0;
            for (int i = point.X+1; i <Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else break;
            }
            return countLeft + countRight >= 5 ;            
        }

        private bool IsEndVertical(Button btn)    //kiểm tra hàng dọc
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for(int i=point.Y+1;i<Cons.CHESS_BOARD_HEIGHT;i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage) 
                {
                    countTop++;
                }
                else break;
            }
            int countBot = 0;
            for (int i = point.Y; i >=0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage) 
                {
                    countBot++;
                }
                else break;
            }
            return countTop + countBot >= 5;
        }

        private bool IsEndPrimary(Button btn)    //đường chéo chính
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)        
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                
                    if (Matrix[point.Y-i][point.X-i].BackgroundImage == btn.BackgroundImage)
                    {
                        countTop++;
                    }
                    else break;
            }
            int countBottom = 0;
            for (int i = 1; i <=Cons.CHESS_BOARD_WIDTH-point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH)
                    break;

                    if (Matrix[point.Y +i][point.X+i].BackgroundImage == btn.BackgroundImage)
                    {
                        countBottom++;
                    }
                    else break;
            }
            return countTop + countBottom >= 5;
        }

        private bool IsEndSub(Button btn)    //đường chéo phụ
        {
                Point point = GetChessPoint(btn);
                int countTop = 0;
                for (int i = 0; i <= point.X; i++)
                {
                    if (point.X + i > Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                        break;

                    if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    {
                        countTop++;
                    }
                    else break;
                }
                int countBottom = 0;
                for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
                {
                    if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i < 0)
                        break;

                    if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    {
                        countBottom++;
                    }
                    else break;
                }
                return countTop + countBottom >= 5;
            }



            //thay đổi hình ảnh người chơi
        private void Team1(Button btn )
        {      
            btn.BackgroundImage = Player[CurrentPlayer].Team1;
            
                 //neu player bằng 1 thì đổi bằng 0 hoặc ngược lại
        }

        //hiển thị ai là người chơi đầu (tái sử dụng hàm btn_click) 
        public void ChangePlayer()
        {
            //thay đổi thong tin của player tiếp theo
            Playername.Text = Player[CurrentPlayer].Name;
            Team.Image = Player[CurrentPlayer].Team1;
            //số game thắng số game thua và số bước của người chơi
            wingame.Text = "Game has won : " +Player[CurrentPlayer].WinGame.ToString();
            losegame.Text = "Game has loss : " + Player[CurrentPlayer].LoseGame.ToString();
            step.Text = "Step in current game : " + Player[CurrentPlayer].Step.ToString();
        }
        #endregion
    }
}
