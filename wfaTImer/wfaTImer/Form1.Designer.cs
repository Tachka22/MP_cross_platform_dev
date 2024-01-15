namespace wfaTImer
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
            this.buUp = new System.Windows.Forms.Button();
            this.buUppause = new System.Windows.Forms.Button();
            this.pbUpSec = new System.Windows.Forms.ProgressBar();
            this.pbUpMs = new System.Windows.Forms.ProgressBar();
            this.LayoutTimer = new System.Windows.Forms.FlowLayoutPanel();
            this.but_StartTimer = new System.Windows.Forms.Button();
            this.but_PauseTimer = new System.Windows.Forms.Button();
            this.but_resetTimer = new System.Windows.Forms.Button();
            this.textBox_hour = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox1_sec = new System.Windows.Forms.TextBox();
            this.label_percent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LayoutTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buUp
            // 
            this.buUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buUp.Location = new System.Drawing.Point(10, 32);
            this.buUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buUp.Name = "buUp";
            this.buUp.Size = new System.Drawing.Size(182, 48);
            this.buUp.TabIndex = 0;
            this.buUp.Text = "00:00:00:000";
            this.buUp.UseVisualStyleBackColor = true;
            // 
            // buUppause
            // 
            this.buUppause.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buUppause.Location = new System.Drawing.Point(214, 32);
            this.buUppause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buUppause.Name = "buUppause";
            this.buUppause.Size = new System.Drawing.Size(82, 48);
            this.buUppause.TabIndex = 1;
            this.buUppause.Text = "||";
            this.buUppause.UseVisualStyleBackColor = true;
            // 
            // pbUpSec
            // 
            this.pbUpSec.Location = new System.Drawing.Point(312, 32);
            this.pbUpSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUpSec.Name = "pbUpSec";
            this.pbUpSec.Size = new System.Drawing.Size(314, 22);
            this.pbUpSec.TabIndex = 2;
            // 
            // pbUpMs
            // 
            this.pbUpMs.Location = new System.Drawing.Point(312, 58);
            this.pbUpMs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUpMs.Name = "pbUpMs";
            this.pbUpMs.Size = new System.Drawing.Size(314, 22);
            this.pbUpMs.TabIndex = 3;
            // 
            // LayoutTimer
            // 
            this.LayoutTimer.Controls.Add(this.but_StartTimer);
            this.LayoutTimer.Controls.Add(this.but_PauseTimer);
            this.LayoutTimer.Controls.Add(this.but_resetTimer);
            this.LayoutTimer.Controls.Add(this.textBox_hour);
            this.LayoutTimer.Controls.Add(this.textBox_min);
            this.LayoutTimer.Controls.Add(this.textBox1_sec);
            this.LayoutTimer.Controls.Add(this.label_percent);
            this.LayoutTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutTimer.Location = new System.Drawing.Point(0, 189);
            this.LayoutTimer.Name = "LayoutTimer";
            this.LayoutTimer.Size = new System.Drawing.Size(700, 124);
            this.LayoutTimer.TabIndex = 4;
            // 
            // but_StartTimer
            // 
            this.but_StartTimer.Location = new System.Drawing.Point(3, 3);
            this.but_StartTimer.Name = "but_StartTimer";
            this.but_StartTimer.Size = new System.Drawing.Size(75, 45);
            this.but_StartTimer.TabIndex = 1;
            this.but_StartTimer.Text = "Старт";
            this.but_StartTimer.UseVisualStyleBackColor = true;
            // 
            // but_PauseTimer
            // 
            this.but_PauseTimer.Location = new System.Drawing.Point(84, 3);
            this.but_PauseTimer.Name = "but_PauseTimer";
            this.but_PauseTimer.Size = new System.Drawing.Size(75, 45);
            this.but_PauseTimer.TabIndex = 2;
            this.but_PauseTimer.Text = "Пауза";
            this.but_PauseTimer.UseVisualStyleBackColor = true;
            // 
            // but_resetTimer
            // 
            this.but_resetTimer.Location = new System.Drawing.Point(165, 3);
            this.but_resetTimer.Name = "but_resetTimer";
            this.but_resetTimer.Size = new System.Drawing.Size(75, 45);
            this.but_resetTimer.TabIndex = 6;
            this.but_resetTimer.Text = "Сброс";
            this.but_resetTimer.UseVisualStyleBackColor = true;
            // 
            // textBox_hour
            // 
            this.textBox_hour.Location = new System.Drawing.Point(246, 3);
            this.textBox_hour.Name = "textBox_hour";
            this.textBox_hour.Size = new System.Drawing.Size(100, 23);
            this.textBox_hour.TabIndex = 5;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(352, 3);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(100, 23);
            this.textBox_min.TabIndex = 4;
            // 
            // textBox1_sec
            // 
            this.textBox1_sec.Location = new System.Drawing.Point(458, 3);
            this.textBox1_sec.Name = "textBox1_sec";
            this.textBox1_sec.Size = new System.Drawing.Size(100, 23);
            this.textBox1_sec.TabIndex = 3;
            // 
            // label_percent
            // 
            this.label_percent.AutoSize = true;
            this.label_percent.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_percent.Location = new System.Drawing.Point(564, 0);
            this.label_percent.Name = "label_percent";
            this.label_percent.Size = new System.Drawing.Size(0, 25);
            this.label_percent.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таймер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 313);
            this.Controls.Add(this.LayoutTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbUpMs);
            this.Controls.Add(this.pbUpSec);
            this.Controls.Add(this.buUppause);
            this.Controls.Add(this.buUp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LayoutTimer.ResumeLayout(false);
            this.LayoutTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buUp;
        private Button buUppause;
        private ProgressBar pbUpSec;
        private ProgressBar pbUpMs;
        private FlowLayoutPanel LayoutTimer;
        private Label label1;
        private Button but_StartTimer;
        private Button but_PauseTimer;
        private TextBox textBox_hour;
        private TextBox textBox_min;
        private TextBox textBox1_sec;
        private Button but_resetTimer;
        private Label label_percent;
    }
}