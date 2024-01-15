using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wfpTemplateData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       ObservableCollection<MyTask> listTasks;
        MyTask newTask = new();
        public MainWindow()
        {
            InitializeComponent();

            List<string> listPhones = new() {"IPhone 12","HTC r1","SAMSUNG 22" };
            listBoxPhones.ItemsSource = listPhones;

            listTasks = new()
            {
                new MyTask(){Name = "МР", Description= "Сделать проект", Priority = 10},
                new MyTask(){Name = "НР", Description= "Пройти тест", Priority = 8},
                new MyTask(){Name = "ДМ", Description= "Подготовиться к тесту", Priority = 5}
            };
            listBoxTasks.ItemsSource = listTasks;

            buAdd.Click += buAdd_Click;
        }

        private void buAdd_Click(object sender, RoutedEventArgs e)
        {
            listTasks.Add(new MyTask() { Name = newTask.Name,Description= newTask.Description, Priority=newTask.Priority });
        }
    }

    internal class MyTask : IDataErrorInfo
    {
        public string this[string columnName]
        {
            
            get
            {
                string error = string.Empty;
                switch(columnName)
                {
                    case:"Name"
                }
            }
            set
            {

                this[columnName] = value;   
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public string Error => throw new NotImplementedException();
    }
}
