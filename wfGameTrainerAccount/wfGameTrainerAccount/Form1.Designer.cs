namespace wfGameTrainerAccount
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.buReset = new System.Windows.Forms.Button();
            this.laCorrect = new System.Windows.Forms.Label();
            this.laWrong = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buNext = new System.Windows.Forms.Button();
            this.buBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buNo = new System.Windows.Forms.Button();
            this.buYes = new System.Windows.Forms.Button();
            this.laCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.Controls.Add(this.cbLevel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buReset, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.laCorrect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.laWrong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbLevel
            // 
            this.cbLevel.AccessibleDescription = "Выберите уровень";
            this.cbLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.ItemHeight = 15;
            this.cbLevel.Items.AddRange(new object[] {
            "Легкий",
            "Средний",
            "Тяжёлый"});
            this.cbLevel.Location = new System.Drawing.Point(613, 47);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(161, 23);
            this.cbLevel.TabIndex = 4;
            // 
            // buReset
            // 
            this.buReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.buReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buReset.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buReset.Location = new System.Drawing.Point(610, 0);
            this.buReset.Margin = new System.Windows.Forms.Padding(0);
            this.buReset.Name = "buReset";
            this.buReset.Size = new System.Drawing.Size(167, 44);
            this.buReset.TabIndex = 4;
            this.buReset.Text = "Начать сначала";
            this.buReset.UseVisualStyleBackColor = false;
            // 
            // laCorrect
            // 
            this.laCorrect.AutoSize = true;
            this.laCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.laCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laCorrect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laCorrect.Location = new System.Drawing.Point(3, 0);
            this.laCorrect.Name = "laCorrect";
            this.laCorrect.Size = new System.Drawing.Size(299, 44);
            this.laCorrect.TabIndex = 0;
            this.laCorrect.Text = "Верно = 0";
            this.laCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laCorrect.Click += new System.EventHandler(this.label1_Click);
            // 
            // laWrong
            // 
            this.laWrong.AutoSize = true;
            this.laWrong.BackColor = System.Drawing.Color.LightCoral;
            this.laWrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laWrong.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laWrong.Location = new System.Drawing.Point(308, 0);
            this.laWrong.Name = "laWrong";
            this.laWrong.Size = new System.Drawing.Size(299, 44);
            this.laWrong.TabIndex = 1;
            this.laWrong.Text = "Неверно = 0";
            this.laWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buNext, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buBack, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(308, 47);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(299, 37);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // buNext
            // 
            this.buNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buNext.Location = new System.Drawing.Point(152, 3);
            this.buNext.Name = "buNext";
            this.buNext.Size = new System.Drawing.Size(144, 31);
            this.buNext.TabIndex = 1;
            this.buNext.Text = "Пропустить";
            this.buNext.UseVisualStyleBackColor = false;
            // 
            // buBack
            // 
            this.buBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buBack.Location = new System.Drawing.Point(3, 3);
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(143, 31);
            this.buBack.TabIndex = 0;
            this.buBack.Text = "Вернуться";
            this.buBack.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buNo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buYes, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 318);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buNo
            // 
            this.buNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buNo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buNo.ForeColor = System.Drawing.Color.Red;
            this.buNo.Location = new System.Drawing.Point(391, 2);
            this.buNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buNo.Name = "buNo";
            this.buNo.Size = new System.Drawing.Size(383, 64);
            this.buNo.TabIndex = 1;
            this.buNo.Text = "Нет";
            this.buNo.UseVisualStyleBackColor = false;
            // 
            // buYes
            // 
            this.buYes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buYes.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buYes.Location = new System.Drawing.Point(3, 2);
            this.buYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buYes.Name = "buYes";
            this.buYes.Size = new System.Drawing.Size(382, 64);
            this.buYes.TabIndex = 0;
            this.buYes.Text = "Да";
            this.buYes.UseVisualStyleBackColor = false;
            // 
            // laCode
            // 
            this.laCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laCode.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laCode.Location = new System.Drawing.Point(226, 133);
            this.laCode.Name = "laCode";
            this.laCode.Size = new System.Drawing.Size(368, 127);
            this.laCode.TabIndex = 2;
            this.laCode.Text = "10+11 = 21";
            this.laCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laCode.Click += new System.EventHandler(this.laCode_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(772, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Верно?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(799, 386);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.laCode);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label laCorrect;
        private Label laWrong;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buNo;
        private Button buYes;
        private Label laCode;
        private Label label4;
        private Button buReset;
        private ComboBox cbLevel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buNext;
        private Button buBack;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}