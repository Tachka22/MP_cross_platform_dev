using static System.Formats.Asn1.AsnWriter;

namespace wfaExam2._0
{
    public partial class Form1 : Form
    {
        Game game = new();
        private PictureBox[,] px;
        private int Rows = 5;
        private int Cols = 5;
        private int cellWidth = 70;
        private int cellHeight = 70;
        private Point startMouseDown;
        private int second = 60;

        private bool stopTimer = false;

        Random random= new Random();
        List<int> randomBlock = new List<int>
        {
           1,2,3
        };
       

        public Form1()
        {
            InitializeComponent();
            timer_game.Tick += Timer_game_Tick;

            CreateMatrix(Rows, Cols);

            label_level.Text = $"Уровень {game.Level}";
        }

        private void Timer_game_Tick(object? sender, EventArgs e)
        {
            second = second - 1;
            if (second == 0)
            {
                timer_game.Stop();
                IsTimerStop();
                
            }
            label_timer.Text = $"00:{second}";
        }

        private void CreateMatrix(int row, int col)
        {
            timer_game.Start();

            var plusX = 200;
            var plusY = 20;
            px = new PictureBox[row, col];

            for ( int r = 0; r < row; r++)
                for ( int c = 0; c < col; c++)
                {
                    px[r, c] = new PictureBox();
                    
                    px[r, c].BorderStyle = BorderStyle.FixedSingle;
                    px[r, c].Size = new Size(cellWidth, cellHeight);
                    px[r, c].MouseClick += Form1_MouseClick;
                    px[r, c].Location = new Point(c * cellWidth , r * cellHeight);

                    var res = random.Next(randomBlock.Count);
                    if(res == 0)
                    {
                        px[r, c].BackColor = Color.Transparent;
                        px[r, c].Tag = 0;

                    }
                    if(res == 1)
                    {
                        px[r, c].BackColor = Color.Blue;
                        px[r, c].Tag = 1;
                    }
                    if(res == 2)
                    {
                        px[r, c].BackColor = Color.Red;
                        px[r, c].Tag = 2;
                    }
                    


                    panel1.Controls.Add(px[r, c]);
                }
            var goodR = random.Next(row);
            var goodC = random.Next(col);
            px[goodR, goodC].BackColor = Color.Green;
            px[goodR, goodC].Tag = 4;
        }
        private void IsTimerStop()
        {

                ClearMatrix(game.Rows, game.Columns);
                MessageBox.Show("Время вышло!");
                game.Level++;
                CreateMatrix(game.Rows, game.Columns);
        }
        private void ClearMatrix(int r, int c)
        {
            for (int row = 0; row < Rows; row++)
                for (int col = 0; col < Cols; col++)
                    px[row, col].Dispose();
        }
        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            if (game.CheckActiveGame())
            {
                if (sender is PictureBox picture)
                {
                    if (e.Button == MouseButtons.Left)
                    {

                        if ((int)picture.Tag == 4 )
                        {
                            label_score.Text = $"Очки {game.Score++} из 10";
                            timer_game.Stop();
                            second = 60;
                            MessageBox.Show("Правильно!");
                            ClearMatrix(game.Rows, game.Columns);

                            var nextC = game.Columns++;
                            var nextR = game.Rows++;
                            CreateMatrix(nextR, nextC);
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Неверно!");
                            ClearMatrix(game.Rows, game.Columns);
                            var nextC = game.Columns++;
                            var nextR = game.Rows++;
                            CreateMatrix(nextR, nextC);
                        }
                        game.Level++;
                        label_level.Text = $"Уровень {game.Level} из {game.MaxLevel}";
                        
                        
                    }
                    //picture.Invalidate();
                }
            }
            else
            {
                MessageBox.Show($"Игра закончилась\t Вы набради:{game.Score}");
            }
        }

    }
}