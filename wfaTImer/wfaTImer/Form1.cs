using Timer = System.Windows.Forms.Timer;

namespace wfaTImer
{
    public partial class Form1 : Form
    {
        private const int SEC_MAX = 10;
        private Timer tmUP = new();
        private Timer tmDOWN = new();
        private DateTime startTimerUp;
        private DateTime pauseTimerUp;
        //-------------------------
        private Timer myTimer = new();

        private int hour;
        private int minute;
        private int second;
        private bool pause = false;
        private double startSeconds;
        private double currentSeconds;

        public Form1()
        {
            InitializeComponent();
            
            tmUP.Interval= 100;//1 сек = 1000 мс
            tmUP.Tick += TmUP_Tick;
            buUp.Click += BuUp_Click;
            buUppause.Click += BuUppause_Click;
            pbUpSec.Maximum = SEC_MAX;
            pbUpMs.Maximum = SEC_MAX * 1000;

            myTimer.Tick += MyTimer_Tick;
            but_StartTimer.Click += But_StartTimer_Click;
            but_resetTimer.Click += But_resetTimer_Click;
            but_PauseTimer.Click += But_PauseTimer_Click;
        }

        private void But_PauseTimer_Click(object? sender, EventArgs e)
        {
            pause = true;
            myTimer.Stop();

        }

        private void But_resetTimer_Click(object? sender, EventArgs e)
        {
            myTimer.Stop();
            textBox1_sec.Text= "0";
            textBox_min.Text= "0";
            textBox_hour.Text= "0";
            label_percent.Text = $"Выполено: %";
            hour = 0;
            minute = 0;
            second= 0;
        }

        private void MyTimer_Tick(object? sender, EventArgs e)
        {
           
            second = second - 1;

            if (second == -1)
            {
                minute = minute - 1;
                second = 59;
            }
            if (minute == -1)
            {
                hour = hour - 1;
                minute = 59;
            }
            if (hour == 0 && minute == 0 && second == 0)
            {
                myTimer.Stop();
                MessageBox.Show("Звонок!");
                label_percent.Text = $"Выполено: 100%";
            }
            currentSeconds = hour * 3600 + minute * 60 + second;
            textBox1_sec.Text = second.ToString();
            textBox_min.Text = minute.ToString();
            textBox_hour.Text = hour.ToString();
            var t = (100 - (currentSeconds / startSeconds * 100)).ToString("0.00");

            label_percent.Text = $"Выполено: {t}%";
        }

        private void But_StartTimer_Click(object? sender, EventArgs e)
        {
            if (pause == false)
            {
                hour = Convert.ToInt32(textBox_hour.Text);
                minute = Convert.ToInt32(textBox_min.Text);
                second = Convert.ToInt32(textBox1_sec.Text);
                startSeconds = hour*3600 + minute*60 + second;
                if(hour == 0 && minute == 0 && second == 0)
                    MessageBox.Show("Звонок!");
                else
                {
                    label_percent.Text = $"Выполено: 0%";
                    myTimer.Interval = 1000;
                    myTimer.Start();
                }
            }
            else 
            {
                myTimer.Interval = 1000;
                myTimer.Start();
            }

        }

        private void BuUppause_Click(object? sender, EventArgs e)
        {
            if(tmUP.Enabled)
            {
                pauseTimerUp = DateTime.Now;
                tmUP.Stop();
               
            }
            else
            {
                startTimerUp = startTimerUp + (DateTime.Now - pauseTimerUp);   
                tmUP.Start();
            }


        }

        private void BuUp_Click(object? sender, EventArgs e)
        {
            tmUP.Enabled = !tmUP.Enabled;
            startTimerUp = DateTime.Now;
        }

        private void TmUP_Tick(object? sender, EventArgs e)
        {
            //1
            //buUp.Text = (DateTime.Now - startTimerUp).ToString(@"hh\:mm\:ss\.fff");
            
            //2
            var x  = (DateTime.Now - startTimerUp);
            if(x.TotalSeconds > SEC_MAX)
            {
                tmUP.Stop();
                x = TimeSpan.FromSeconds(SEC_MAX);

            }
            buUp.Text = x.ToString(@"hh\:mm\:ss\.fff");
            pbUpSec.Value = (int)x.TotalSeconds;
            pbUpMs.Value = (int)x.TotalMilliseconds;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}