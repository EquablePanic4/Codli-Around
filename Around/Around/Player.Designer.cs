namespace Around
{
    partial class Player
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
            this.ConnectionKeyBox = new System.Windows.Forms.TextBox();
            this.ConnectionKeyLabel = new System.Windows.Forms.Label();
            this.ConnectToServerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitPlayerBtn = new System.Windows.Forms.Button();
            this.PlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionKeyBox
            // 
            this.ConnectionKeyBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ConnectionKeyBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionKeyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ConnectionKeyBox.Location = new System.Drawing.Point(283, 63);
            this.ConnectionKeyBox.MaxLength = 9;
            this.ConnectionKeyBox.Name = "ConnectionKeyBox";
            this.ConnectionKeyBox.Size = new System.Drawing.Size(142, 30);
            this.ConnectionKeyBox.TabIndex = 1;
            this.ConnectionKeyBox.TextChanged += new System.EventHandler(this.ConnectionKeyBox_TextChanged);
            // 
            // ConnectionKeyLabel
            // 
            this.ConnectionKeyLabel.AutoSize = true;
            this.ConnectionKeyLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectionKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ConnectionKeyLabel.Location = new System.Drawing.Point(12, 63);
            this.ConnectionKeyLabel.Name = "ConnectionKeyLabel";
            this.ConnectionKeyLabel.Size = new System.Drawing.Size(265, 25);
            this.ConnectionKeyLabel.TabIndex = 2;
            this.ConnectionKeyLabel.Text = "Wprowadź kod połączenia: ";
            // 
            // ConnectToServerBtn
            // 
            this.ConnectToServerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ConnectToServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectToServerBtn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectToServerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ConnectToServerBtn.Location = new System.Drawing.Point(431, 58);
            this.ConnectToServerBtn.Name = "ConnectToServerBtn";
            this.ConnectToServerBtn.Size = new System.Drawing.Size(358, 38);
            this.ConnectToServerBtn.TabIndex = 3;
            this.ConnectToServerBtn.Text = "Połącz";
            this.ConnectToServerBtn.UseVisualStyleBackColor = false;
            this.ConnectToServerBtn.Click += new System.EventHandler(this.ConnectToServerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ExitPlayerBtn);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 48);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codli Around Player";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMove);
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMove);
            // 
            // ExitPlayerBtn
            // 
            this.ExitPlayerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitPlayerBtn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitPlayerBtn.ForeColor = System.Drawing.Color.White;
            this.ExitPlayerBtn.Location = new System.Drawing.Point(749, 4);
            this.ExitPlayerBtn.Name = "ExitPlayerBtn";
            this.ExitPlayerBtn.Size = new System.Drawing.Size(44, 41);
            this.ExitPlayerBtn.TabIndex = 0;
            this.ExitPlayerBtn.Text = "X";
            this.ExitPlayerBtn.UseVisualStyleBackColor = false;
            this.ExitPlayerBtn.Click += new System.EventHandler(this.ExitPlayerBtn_Click);
            // 
            // PlayerGroupBox
            // 
            this.PlayerGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerGroupBox.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerGroupBox.Location = new System.Drawing.Point(12, 99);
            this.PlayerGroupBox.Name = "PlayerGroupBox";
            this.PlayerGroupBox.Size = new System.Drawing.Size(776, 339);
            this.PlayerGroupBox.TabIndex = 7;
            this.PlayerGroupBox.TabStop = false;
            this.PlayerGroupBox.Text = "Odtwarzacz";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnectToServerBtn);
            this.Controls.Add(this.ConnectionKeyLabel);
            this.Controls.Add(this.ConnectionKeyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player";
            this.Text = "Player";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ConnectionKeyBox;
        private System.Windows.Forms.Label ConnectionKeyLabel;
        private System.Windows.Forms.Button ConnectToServerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitPlayerBtn;
        private System.Windows.Forms.GroupBox PlayerGroupBox;
    }
}