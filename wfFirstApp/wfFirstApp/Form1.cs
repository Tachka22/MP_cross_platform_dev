using System.Diagnostics;

namespace wfFirstApp
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
            button2.Click += Button2_Click;
            button3.Click += delegate
            {
                MessageBox.Show("Способ № 3");
            };
            button4.Click += (s, e) => MessageBox.Show("Способ № 4");
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Способ № 2");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ № 1");
        }

        
    }
}