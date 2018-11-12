namespace Around
{
    partial class Streamer
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
            this.ExitStreamerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StreamingCodeLabel = new System.Windows.Forms.Label();
            this.ConnectedDevicesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.SyncBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SyncProgressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitStreamerBtn
            // 
            this.ExitStreamerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitStreamerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitStreamerBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitStreamerBtn.ForeColor = System.Drawing.Color.White;
            this.ExitStreamerBtn.Location = new System.Drawing.Point(749, 4);
            this.ExitStreamerBtn.Name = "ExitStreamerBtn";
            this.ExitStreamerBtn.Size = new System.Drawing.Size(44, 41);
            this.ExitStreamerBtn.TabIndex = 0;
            this.ExitStreamerBtn.Text = "X";
            this.ExitStreamerBtn.UseVisualStyleBackColor = false;
            this.ExitStreamerBtn.Click += new System.EventHandler(this.ExitStreamerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kod streamingu";
            // 
            // StreamingCodeLabel
            // 
            this.StreamingCodeLabel.AutoSize = true;
            this.StreamingCodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.StreamingCodeLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StreamingCodeLabel.Location = new System.Drawing.Point(12, 93);
            this.StreamingCodeLabel.Name = "StreamingCodeLabel";
            this.StreamingCodeLabel.Size = new System.Drawing.Size(179, 37);
            this.StreamingCodeLabel.TabIndex = 2;
            this.StreamingCodeLabel.Text = "8795-DF85";
            // 
            // ConnectedDevicesLabel
            // 
            this.ConnectedDevicesLabel.AutoSize = true;
            this.ConnectedDevicesLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectedDevicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ConnectedDevicesLabel.Location = new System.Drawing.Point(562, 58);
            this.ConnectedDevicesLabel.Name = "ConnectedDevicesLabel";
            this.ConnectedDevicesLabel.Size = new System.Drawing.Size(180, 25);
            this.ConnectedDevicesLabel.TabIndex = 4;
            this.ConnectedDevicesLabel.Text = "Podłączeni klienci:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ExitStreamerBtn);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 48);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Streamer_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.label2.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(63, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codli Around Streamer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Around.Properties.Resources.Codli_Around;
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.PlayBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SyncProgressBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SyncBtn);
            this.groupBox1.Controls.Add(this.ChooseFileBtn);
            this.groupBox1.Controls.Add(this.FilePathBox);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 288);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odtwarzanie";
            // 
            // FilePathBox
            // 
            this.FilePathBox.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilePathBox.Location = new System.Drawing.Point(47, 56);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.ReadOnly = true;
            this.FilePathBox.Size = new System.Drawing.Size(593, 23);
            this.FilePathBox.TabIndex = 0;
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ChooseFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.ChooseFileBtn.Location = new System.Drawing.Point(7, 51);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(34, 30);
            this.ChooseFileBtn.TabIndex = 1;
            this.ChooseFileBtn.Text = "...";
            this.ChooseFileBtn.UseVisualStyleBackColor = false;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // SyncBtn
            // 
            this.SyncBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.SyncBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncBtn.Font = new System.Drawing.Font("Lato", 11.25F);
            this.SyncBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.SyncBtn.Location = new System.Drawing.Point(651, 51);
            this.SyncBtn.Name = "SyncBtn";
            this.SyncBtn.Size = new System.Drawing.Size(119, 30);
            this.SyncBtn.TabIndex = 2;
            this.SyncBtn.Text = "Synchronizuj";
            this.SyncBtn.UseVisualStyleBackColor = false;
            this.SyncBtn.Click += new System.EventHandler(this.SyncBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wybierz plik który chcesz odtworzyć";
            // 
            // SyncProgressBar
            // 
            this.SyncProgressBar.Location = new System.Drawing.Point(9, 259);
            this.SyncProgressBar.Name = "SyncProgressBar";
            this.SyncProgressBar.Size = new System.Drawing.Size(761, 23);
            this.SyncProgressBar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Postęp synchronizacji";
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(143, 137);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(182, 58);
            this.PlayBtn.TabIndex = 6;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(393, 137);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(182, 58);
            this.StopBtn.TabIndex = 7;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // Streamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnectedDevicesLabel);
            this.Controls.Add(this.StreamingCodeLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Streamer";
            this.Text = "Streamer";
            this.Load += new System.EventHandler(this.Streamer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Streamer_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitStreamerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StreamingCodeLabel;
        private System.Windows.Forms.Label ConnectedDevicesLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SyncBtn;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar SyncProgressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PlayBtn;
    }
}