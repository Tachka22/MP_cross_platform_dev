namespace wpfAppExplorer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел0");
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUp = new System.Windows.Forms.ToolStripButton();
            this.edDir = new System.Windows.Forms.ToolStripTextBox();
            this.buDirSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.miViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.imLarge = new System.Windows.Forms.ImageList(this.components);
            this.imSmall = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ls1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv = new System.Windows.Forms.ListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.toolStripSeparator1,
            this.btnForward,
            this.toolStripSeparator2,
            this.btnUp,
            this.edDir,
            this.buDirSelect,
            this.toolStripDropDownButton1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(852, 27);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 24);
            this.btnBack.Text = "←";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(29, 24);
            this.btnForward.Text = "→";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnUp
            // 
            this.btnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(29, 24);
            this.btnUp.Text = "↑";
            // 
            // edDir
            // 
            this.edDir.Name = "edDir";
            this.edDir.Size = new System.Drawing.Size(400, 27);
            // 
            // buDirSelect
            // 
            this.buDirSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buDirSelect.Image = ((System.Drawing.Image)(resources.GetObject("buDirSelect.Image")));
            this.buDirSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buDirSelect.Name = "buDirSelect";
            this.buDirSelect.Size = new System.Drawing.Size(29, 24);
            this.buDirSelect.Text = "...";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewLargeIcon,
            this.miViewSmallIcon,
            this.miViewList,
            this.miViewDetails,
            this.miViewTile});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 24);
            this.toolStripDropDownButton1.Text = "Вид";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // miViewLargeIcon
            // 
            this.miViewLargeIcon.Name = "miViewLargeIcon";
            this.miViewLargeIcon.Size = new System.Drawing.Size(206, 26);
            this.miViewLargeIcon.Text = "Крупные значки";
            // 
            // miViewSmallIcon
            // 
            this.miViewSmallIcon.Name = "miViewSmallIcon";
            this.miViewSmallIcon.Size = new System.Drawing.Size(206, 26);
            this.miViewSmallIcon.Text = "Мелкие значик";
            // 
            // miViewList
            // 
            this.miViewList.Name = "miViewList";
            this.miViewList.Size = new System.Drawing.Size(206, 26);
            this.miViewList.Text = "Список";
            // 
            // miViewDetails
            // 
            this.miViewDetails.Name = "miViewDetails";
            this.miViewDetails.Size = new System.Drawing.Size(206, 26);
            this.miViewDetails.Text = "Таблица";
            // 
            // miViewTile
            // 
            this.miViewTile.Name = "miViewTile";
            this.miViewTile.Size = new System.Drawing.Size(206, 26);
            this.miViewTile.Text = "Плитки";
            // 
            // imLarge
            // 
            this.imLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imLarge.ImageStream")));
            this.imLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imLarge.Images.SetKeyName(0, "folder");
            this.imLarge.Images.SetKeyName(1, "file");
            // 
            // imSmall
            // 
            this.imSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imSmall.ImageStream")));
            this.imSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imSmall.Images.SetKeyName(0, "folder_low");
            this.imSmall.Images.SetKeyName(1, "file_low");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ls1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ls1
            // 
            this.ls1.Name = "ls1";
            this.ls1.Size = new System.Drawing.Size(151, 20);
            this.ls1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 462);
            this.panel1.TabIndex = 5;
            // 
            // lv
            // 
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.LargeImageList = this.imLarge;
            this.lv.Location = new System.Drawing.Point(213, 0);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(639, 462);
            this.lv.SmallImageList = this.imSmall;
            this.lv.TabIndex = 5;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(209, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 462);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imSmall;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Узел0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(209, 462);
            this.treeView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStripMain;
        private ToolStripButton btnBack;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnForward;
        private ToolStripButton btnUp;
        private ToolStripTextBox edDir;
        private ToolStripButton buDirSelect;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private Splitter splitter1;
        private TreeView treeView1;
        private ImageList imLarge;
        private ImageList imSmall;
        private ListView lv;
        private ToolStripStatusLabel ls1;
        private ToolStripMenuItem miViewLargeIcon;
        private ToolStripMenuItem miViewSmallIcon;
        private ToolStripMenuItem miViewList;
        private ToolStripMenuItem miViewDetails;
        private ToolStripMenuItem miViewTile;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}