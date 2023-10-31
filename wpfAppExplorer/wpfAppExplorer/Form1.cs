using System.Windows.Forms;

namespace wpfAppExplorer
{
    public partial class Form1 : Form
    {
        private string CurDir;

        public string CurDir1
        {
            get => CurDir;
            private set
            {
                CurDir = value;
                edDir.Text = CurDir;
            }
        }

        public string SelectItem { get; private set; }

        public Form1()
        {
            InitializeComponent();
            btnUp.Click += (s, e) => LoadDir(Directory.GetParent(CurDir).ToString());
            edDir.KeyDown += EdDir_KeyDown;
            buDirSelect.Click += BuDirSelect_Click;
            lv.ItemSelectionChanged += Lv_ItemSelectionChanged;
            lv.DoubleClick += Lv_DoubleClick;

            miViewLargeIcon.Click += (s, e) => lv.View = View.LargeIcon;
            miViewSmallIcon.Click += (s, e) => lv.View = View.SmallIcon;
            miViewList.Click += (s, e) => lv.View = View.List;
            miViewDetails.Click += (s, e) => lv.View = View.Details;
            miViewTile.Click += (s, e) => lv.View = View.Tile;

            //1
            //ColumnHeader c1 = new();
            //c1.Text= "Имя";
            //c1.Width = 350;
            //lv.Columns.Add(c1);
            //2
            //lv.Columns.Add(new ColumnHeader
            //{
            //    Text = "Имя",
            //    Width= 350
            //});
            //3
            //lv.Columns.Add("Имя", 350);
            //lv.Columns.Add("Дата изменения", 150);
            //lv.Columns.Add("Тип", 100);
            //lv.Columns.Add("Размер", 150);

            //4
            var myDict = new Dictionary<string, int>
            {
                { "Имя", 350 },
                { "Дата изменения", 150 },
                { "Тип", 100},
                { "Размер", 150}    
            };
            foreach (var item in myDict)
                lv.Columns.Add(item.Key, item.Value);

            lv.ContextMenuStrip = contextMenuStrip1;

            
            this.Text += $": Drives ={ string.Join(" ", Directory.GetLogicalDrives())} ";

            foreach (var item in Directory.GetLogicalDrives())
            {
                treeView1.Nodes.Add(item);
            }
            
            treeView1.DoubleClick += TreeView1_DoubleClick;
            CurDir = Directory.GetCurrentDirectory();
            LoadDir(CurDir);

        }

        private void TreeView1_DoubleClick(object? sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new(treeView1.SelectedNode.FullPath);
            treeView1.BeginUpdate();
            treeView1.SelectedNode.Nodes.Clear();
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeView1.SelectedNode.Nodes.Add(item.FullName, item.Name, 0);
                treeView1.SelectedNode.Expand();    
            }
            treeView1.EndUpdate();
            
            LoadDir(treeView1.SelectedNode.FullPath);

        }

        private void Lv_DoubleClick(object? sender, EventArgs e)
        {
            LoadDir(SelectItem);
        }

        private void Lv_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            SelectItem = Path.Combine(CurDir, e.Item.Text);
            
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            ls1.Text = string.Empty;
            ls1.Text = $"Элементов: {lv.Items.Count}, Выбрано: {lv.SelectedItems.Count}";
        }

        private void BuDirSelect_Click(object? sender, EventArgs e)
        {
            FolderBrowserDialog dia = new FolderBrowserDialog();
            if(dia.ShowDialog() == DialogResult.OK)
            {
                LoadDir(dia.SelectedPath);
            }
        }

        private void EdDir_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadDir(edDir.Text);
            }
        }

        private void LoadDir(string newDir)
        {
            DirectoryInfo DI = new(newDir);
            lv.Items.Clear();
            lv.BeginUpdate();
            foreach (var item in DI.GetDirectories())
            {
                //lv.Items.Add(item.Name, 0);
                lv.Items.Add(
                    new ListViewItem(new string[] { item.Name, item.LastWriteTime.ToString(), "Папка",  }, 0));
            }

            foreach (var item in DI.GetFiles())
            {
                //1
                //lv.Items.Add(item.Name, 1);

                //2
                lv.Items.Add(
                    new ListViewItem(new string[] { item.Name, item.LastWriteTime.ToString(), "Файл" + item.Extension.ToString(), item.Length.ToString() + "байт" }, 1)) ;
            }
            lv.EndUpdate();
            CurDir = newDir;
            edDir.Text = newDir;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edDir_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}