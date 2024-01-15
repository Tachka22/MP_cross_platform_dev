using System.Security.Cryptography.X509Certificates;
using wfaDrawPlayBoard;
using wfaDrawPlayBoard2._0.Model;

namespace wfaDrawPlayBoard2._0
{
    public partial class Form1 : Form
    {
        Panel square = new();
        Label letterLabel = new();
        Label numberLabel = new();

        GoBoard goBoard = new();
        BlackWhiteChessBoard BWchessboard = new();
        NavalbattleBoard navalbattle = new();
        Chessboard chessboard = new();
        public Form1()
        {
            InitializeComponent();
            radioButton1.Click += RadioButton1_Click;
            radioButton2.Click += RadioButton2_Click;
            radioButton3_BWboard.Click += RadioButton3_BWboard_Click;
            radioButtonGo.Click += RadioButtonGo_Click;
            trackBar1.Scroll += TrackBar1_Scroll;
            this.Height = 900;
            this.Width= 1600;
            
        }

        private void TrackBar1_Scroll(object? sender, EventArgs e)
        {
            trackBar1.Minimum= 20;
            trackBar1.Maximum = 100;
            label1.Text = string.Format("Размер ячейкри: {0}", trackBar1.Value);
            goBoard.ItemSize = trackBar1.Value;
            chessboard.ItemSize= trackBar1.Value;
            BWchessboard.ItemSize = trackBar1.Value;
            navalbattle.ItemSize= trackBar1.Value;


        }

        private void RadioButtonGo_Click(object? sender, EventArgs e)
        {
            if(radioButtonGo.Checked)
            {
                drawpanel.Controls.Clear();
                DrawPlayBoard(
                    goBoard.ItemSize,
                    goBoard.BoardSize,
                    goBoard.Color1,
                    goBoard.Color2,
                    goBoard.BackgrounColor,
                    goBoard.Name,
                    false,
                    false);
            }
        }

        private void DrawPlayBoard(int itemsize, int boardszie, Color clr1, Color clr2, Color backclr, string name, bool LTText, bool ALLText)
        {
            var s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var t = boardszie - 1;

            this.Text= name;
            drawpanel.BackColor = backclr;
            int x = itemsize, y = 0;
            if(LTText == true || ALLText== true) {
                // Добавляем буквенную нумерацию столбцов сверху доски
                for (int column = 0; column < boardszie; column++)
                {
                    letterLabel = new Label();
                    //letterLabel.Text = ((char)('H' - column)).ToString();
                    letterLabel.Text = (s[t - column]).ToString();
                    letterLabel.Size = new Size(itemsize, itemsize);
                    letterLabel.Font = new Font("Times New Roman", 16.0f);
                    letterLabel.Location = new Point(x, y);
                    letterLabel.TextAlign = ContentAlignment.MiddleCenter;
                    drawpanel.Controls.Add(letterLabel);

                    x += itemsize;
                }
            }
            

             x = itemsize;
             y = itemsize;

            for (int row = 0; row < boardszie; row++)
            {
                // Добавляем цифровую нумерацию строк слева от доски
                if(LTText == true || ALLText == true)
                {
                    numberLabel = new Label();
                    numberLabel.Text = (boardszie - row).ToString();
                    numberLabel.Size = new Size(itemsize, itemsize);
                    numberLabel.Font = new Font("Times New Roman", 16.0f);
                    numberLabel.Location = new Point(x - itemsize, y);
                    numberLabel.TextAlign = ContentAlignment.MiddleCenter;
                    drawpanel.Controls.Add(numberLabel);
                }

                for (int column = 0; column < boardszie; column++)
                {
                    square = new Panel();
                    square.Size = new Size(itemsize, itemsize);
                    square.Location = new Point(x, y);
                    square.BackColor = (row + column) % 2 == 0 ? clr1 : clr2;
                    square.BorderStyle = BorderStyle.FixedSingle;

                    drawpanel.Controls.Add(square);
                    

                    x += itemsize;

                }
                if(LTText == false && ALLText == true)
                {
                    numberLabel = new Label();
                    var num = row + 1;
                    numberLabel.Text = ( num).ToString();
                    numberLabel.Size = new Size(itemsize, itemsize);
                    numberLabel.Font = new Font("Times New Roman", 16.0f);
                    numberLabel.Location = new Point(x, y);
                    numberLabel.TextAlign = ContentAlignment.MiddleCenter;
                    drawpanel.Controls.Add(numberLabel);

                }
                x = itemsize;
                y += itemsize;

            }
            Controls.Add(flowLayoutPanel1);

            // Добавляем буквенную нумерацию столбцов снизу доски
            if(LTText == false && ALLText == true)
            {
                for (int column = 0; column < boardszie; column++)
                {
                    letterLabel = new Label();
                    letterLabel.Text = ((char)('A' + column)).ToString();
                    letterLabel.Size = new Size(itemsize, itemsize);
                    letterLabel.Font = new Font("Times New Roman", 16.0f);
                    letterLabel.Location = new Point(x, y);
                    letterLabel.TextAlign = ContentAlignment.MiddleCenter;
                    drawpanel.Controls.Add((letterLabel));

                    x += itemsize;
                }
            }
            

        }

        private void RadioButton3_BWboard_Click(object? sender, EventArgs e)
        {
            if (radioButton3_BWboard.Checked)
            {
                drawpanel.Controls.Clear();
                
                DrawPlayBoard(
                    BWchessboard.ItemSize,
                    BWchessboard.BoardSize,
                    BWchessboard.Color1,
                    BWchessboard.Color2,
                    BWchessboard.BackgrounColor,
                    BWchessboard.Name,
                    false,
                    true);
            }
        }
        private void RadioButton2_Click(object? sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                drawpanel.Controls.Clear();
                
                DrawPlayBoard(
                    navalbattle.ItemSize,
                    navalbattle.BoardSize,
                    navalbattle.Color1,
                    navalbattle.Color2,
                    navalbattle.BackgrounColor,
                    navalbattle.Name,
                    true,
                    false);
            }
        }

        private void RadioButton1_Click(object? sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                drawpanel.Controls.Clear();
                
                DrawPlayBoard(
                    chessboard.ItemSize,
                    chessboard.BoardSize,
                    chessboard.Color1,
                    chessboard.Color2,
                    chessboard.BackgrounColor,
                    chessboard.Name,
                    false,
                    true);
            }
        }
    }
}