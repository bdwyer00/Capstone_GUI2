
namespace Project_Lab_4_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Show_Data = new System.Windows.Forms.Button();
            this.baseRecoringPNG = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Time_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Status_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.playBaseButton = new System.Windows.Forms.Button();
            this.playSampleButton = new System.Windows.Forms.Button();
            this.sampleRecordingPNG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.baseRecoringPNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleRecordingPNG)).BeginInit();
            this.SuspendLayout();
            // 
            // Show_Data
            // 
            this.Show_Data.Location = new System.Drawing.Point(57, 934);
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.Size = new System.Drawing.Size(593, 192);
            this.Show_Data.TabIndex = 0;
            this.Show_Data.Text = "Show Latest Recording Data";
            this.Show_Data.UseVisualStyleBackColor = true;
            this.Show_Data.Click += new System.EventHandler(this.Show_Data_Click);
            // 
            // baseRecoringPNG
            // 
            this.baseRecoringPNG.Location = new System.Drawing.Point(57, 98);
            this.baseRecoringPNG.Name = "baseRecoringPNG";
            this.baseRecoringPNG.Size = new System.Drawing.Size(656, 548);
            this.baseRecoringPNG.TabIndex = 2;
            this.baseRecoringPNG.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base Recording PSD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(923, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Latest Recording PSD";
            // 
            // Time_textBox
            // 
            this.Time_textBox.Location = new System.Drawing.Point(929, 934);
            this.Time_textBox.Name = "Time_textBox";
            this.Time_textBox.Size = new System.Drawing.Size(652, 38);
            this.Time_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 883);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time of Recording";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(58, 1209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(592, 48);
            this.progressBar1.TabIndex = 8;
            // 
            // Status_textBox
            // 
            this.Status_textBox.Location = new System.Drawing.Point(929, 1086);
            this.Status_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.Status_textBox.Name = "Status_textBox";
            this.Status_textBox.Size = new System.Drawing.Size(648, 38);
            this.Status_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 1029);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1165, 1168);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(416, 89);
            this.Close.TabIndex = 11;
            this.Close.Text = "Close Application";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // playBaseButton
            // 
            this.playBaseButton.Location = new System.Drawing.Point(58, 682);
            this.playBaseButton.Name = "playBaseButton";
            this.playBaseButton.Size = new System.Drawing.Size(403, 118);
            this.playBaseButton.TabIndex = 12;
            this.playBaseButton.Text = "Play Base Recording";
            this.playBaseButton.UseVisualStyleBackColor = true;
            this.playBaseButton.Click += new System.EventHandler(this.playBaseButton_Click);
            // 
            // playSampleButton
            // 
            this.playSampleButton.Location = new System.Drawing.Point(929, 682);
            this.playSampleButton.Margin = new System.Windows.Forms.Padding(0);
            this.playSampleButton.Name = "playSampleButton";
            this.playSampleButton.Size = new System.Drawing.Size(380, 118);
            this.playSampleButton.TabIndex = 13;
            this.playSampleButton.Text = "Play Sample Recording";
            this.playSampleButton.UseVisualStyleBackColor = true;
            this.playSampleButton.Click += new System.EventHandler(this.playSampleButton_Click);
            // 
            // sampleRecordingPNG
            // 
            this.sampleRecordingPNG.Location = new System.Drawing.Point(921, 98);
            this.sampleRecordingPNG.Name = "sampleRecordingPNG";
            this.sampleRecordingPNG.Size = new System.Drawing.Size(656, 548);
            this.sampleRecordingPNG.TabIndex = 14;
            this.sampleRecordingPNG.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1651, 1345);
            this.Controls.Add(this.sampleRecordingPNG);
            this.Controls.Add(this.playSampleButton);
            this.Controls.Add(this.playBaseButton);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Status_textBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Time_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baseRecoringPNG);
            this.Controls.Add(this.Show_Data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 40, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrical EnginHEARING";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.baseRecoringPNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleRecordingPNG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show_Data;
        private System.Windows.Forms.PictureBox baseRecoringPNG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Time_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox Status_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button playBaseButton;
        private System.Windows.Forms.Button playSampleButton;
        private System.Windows.Forms.PictureBox sampleRecordingPNG;
    }
}

