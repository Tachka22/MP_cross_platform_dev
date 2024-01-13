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

        public Form1()
        {
            InitializeComponent();
            
            tmUP.Interval= 100;//1 сек = 1000 мс
            tmUP.Tick += TmUP_Tick;
            buUp.Click += BuUp_Click;
            buUppause.Click += BuUppause_Click;
            pbUpSec.Maximum = SEC_MAX;
            pbUpMs.Maximum = SEC_MAX * 1000;
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