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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.buUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buUp.Location = new System.Drawing.Point(12, 42);
            this.buUp.Name = "button1";
            this.buUp.Size = new System.Drawing.Size(208, 64);
            this.buUp.TabIndex = 0;
            this.buUp.Text = "00:00:00:000";
            this.buUp.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.buUppause.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buUppause.Location = new System.Drawing.Point(245, 42);
            this.buUppause.Name = "button2";
            this.buUppause.Size = new System.Drawing.Size(94, 64);
            this.buUppause.TabIndex = 1;
            this.buUppause.Text = "||";
            this.buUppause.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.pbUpSec.Location = new System.Drawing.Point(357, 42);
            this.pbUpSec.Name = "progressBar1";
            this.pbUpSec.Size = new System.Drawing.Size(359, 29);
            this.pbUpSec.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.pbUpMs.Location = new System.Drawing.Point(357, 77);
            this.pbUpMs.Name = "progressBar2";
            this.pbUpMs.Size = new System.Drawing.Size(359, 29);
            this.pbUpMs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 149);
            this.Controls.Add(this.pbUpMs);
            this.Controls.Add(this.pbUpSec);
            this.Controls.Add(this.buUppause);
            this.Controls.Add(this.buUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buUp;
        private Button buUppause;
        private ProgressBar pbUpSec;
        private ProgressBar pbUpMs;
    }
}