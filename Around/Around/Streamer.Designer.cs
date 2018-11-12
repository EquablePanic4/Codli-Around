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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.ConnectedDevicesLabel.Location = new System.Drawing.Point(14, 153);
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
            // Streamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}