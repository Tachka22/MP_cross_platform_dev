using System.Windows.Forms;

namespace wfGameTrainerAccount
{
    public partial class Form1 : Form
    {
        private readonly Game g;

        public Form1()
        {
            InitializeComponent();

            g = new Game();
            g.Change += G_Change;
            g.DoReset();
            buYes.Click += (s, e) => g.DoAnswer(true);
            buNo.Click += (s, e) => g.DoAnswer(false);
            buReset.Click += BuReset_Click;
            cbLevel.SelectedIndexChanged += CbLevel_SelectedIndexChanged;
            buBack.Click += BuBack_Click;
            buNext.Click += BuNext_Click;

        }

        private void BuNext_Click(object? sender, EventArgs e)
        {
            g.GoNext();
        }

        private void BuBack_Click(object? sender, EventArgs e)
        {   if (g.CheckZeroStack()) MessageBox.Show("Пропущенных примеров нету");
            else g.GetBackCase();
        }

        private void CbLevel_SelectedIndexChanged(object? sender, EventArgs e)
        {
            g.Level = (int)cbLevel.SelectedIndex;
        }

        private void BuReset_Click(object? sender, EventArgs e)
        {
            g.DoReset();
        }

        private void G_Change(object? sender, EventArgs e)
        {
            laCorrect.Text = $"Верно = {g.CountCorrect}";
            laWrong.Text = $"Неверно = {g.CountWrong}";
            laCode.Text = g.CodeText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void laCode_Click(object sender, EventArgs e)
        {

        }
    }
}