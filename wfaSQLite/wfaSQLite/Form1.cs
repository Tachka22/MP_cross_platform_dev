using Microsoft.Data.Sqlite;

namespace wfaSQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //���������� ����� NuGet ����� sqllite-net
            using (var connection = new SqliteConnection("Data Source=usersdata.db"))
            {
                connection.Open();
            }
            

        }
    }
}