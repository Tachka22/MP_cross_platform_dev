using System.Windows.Forms;

namespace wfControllnTip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<PictureBox> list = new List<PictureBox>();
            list.Add(pictureBox1);
            list.Add(pictureBox2);
            list.Add(pictureBox3);
            list.Add(pictureBox4);
            list.Add(pictureBox5);
            list.Add(pictureBox6);
            list.Add(pictureBox7);
            list.Add(pictureBox8);
            list.Add(pictureBox9);
            int counter = 1;
            list.ForEach(px =>
            {
                px.Tag = counter++;
                px.MouseLeave += PictureBoxAll_MouseLeave;
                px.MouseEnter += PictureBoxAll_MouseEnter;
                px.MouseClick += PictureBoxAll_MouseClick;
                px.Image = imageList1.Images[0];
                px.SizeMode = PictureBoxSizeMode.Zoom;
            });

            this.Text += " : LClick/RClick - Select Item";
        }

        private void PictureBoxAll_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is PictureBox px)
            {
                px.Image = imageList1.Images[0];
            }
        }

        private void PictureBoxAll_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is PictureBox px)
            {
                px.Image = imageList1.Images[Convert.ToInt32(px.Tag)];
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void PictureBoxAll_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender is PictureBox px)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        px.BorderStyle = px.BorderStyle == BorderStyle.None ? BorderStyle.FixedSingle :
                            BorderStyle.None;
                        break;
                    case MouseButtons.Right:
                        px.BackColor = px.BackColor == SystemColors.Control ? Color.LightBlue :
                            SystemColors.Control;
                        break;
                }
            }
        }
    }
}