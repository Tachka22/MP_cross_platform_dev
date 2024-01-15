namespace wfaSearchCity
{
    public partial class Form1 : Form
    {
        private string[] cities;

        public Form1()
        {
            InitializeComponent();
            cities = Properties.Resources.txt_cities_russia.Split('\n');
            edSearch.TextChanged += EdSearch_TextChanged;

            this.Text += $" : {cities.Count()}"; 
        }

        private void EdSearch_TextChanged(object? sender, EventArgs e)
        {
            var r = cities.Where(x => x.ToUpper().Contains(edSearch.Text.ToUpper()))
                .OrderBy(x => x)
                .ToArray();
            edResult.Text = string.Join(Environment.NewLine, r);  
        }
    }
}