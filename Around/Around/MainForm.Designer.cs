namespace Around
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RunStreamerBtn = new System.Windows.Forms.Button();
            this.RunPlayerBtn = new System.Windows.Forms.Button();
            this.Exit1Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InterfacesListBox = new System.Windows.Forms.ListBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz tryb pracy Around";
            // 
            // RunStreamerBtn
            // 
            this.RunStreamerBtn.BackColor = System.Drawing.Color.Silver;
            this.RunStreamerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunStreamerBtn.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunStreamerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.RunStreamerBtn.Location = new System.Drawing.Point(12, 170);
            this.RunStreamerBtn.Name = "RunStreamerBtn";
            this.RunStreamerBtn.Size = new System.Drawing.Size(506, 35);
            this.RunStreamerBtn.TabIndex = 1;
            this.RunStreamerBtn.Text = "Streamer";
            this.RunStreamerBtn.UseVisualStyleBackColor = false;
            this.RunStreamerBtn.Click += new System.EventHandler(this.RunStreamerBtn_Click);
            // 
            // RunPlayerBtn
            // 
            this.RunPlayerBtn.BackColor = System.Drawing.Color.Silver;
            this.RunPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunPlayerBtn.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunPlayerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.RunPlayerBtn.Location = new System.Drawing.Point(12, 118);
            this.RunPlayerBtn.Name = "RunPlayerBtn";
            this.RunPlayerBtn.Size = new System.Drawing.Size(506, 35);
            this.RunPlayerBtn.TabIndex = 2;
            this.RunPlayerBtn.Text = "Player";
            this.RunPlayerBtn.UseVisualStyleBackColor = false;
            this.RunPlayerBtn.Click += new System.EventHandler(this.RunPlayerBtn_Click);
            // 
            // Exit1Btn
            // 
            this.Exit1Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit1Btn.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit1Btn.ForeColor = System.Drawing.Color.White;
            this.Exit1Btn.Location = new System.Drawing.Point(482, 7);
            this.Exit1Btn.Name = "Exit1Btn";
            this.Exit1Btn.Size = new System.Drawing.Size(38, 41);
            this.Exit1Btn.TabIndex = 4;
            this.Exit1Btn.Text = "X";
            this.Exit1Btn.UseVisualStyleBackColor = false;
            this.Exit1Btn.Click += new System.EventHandler(this.Exit1Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(13, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wybierz interfejs sieciowy";
            // 
            // InterfacesListBox
            // 
            this.InterfacesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.InterfacesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InterfacesListBox.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InterfacesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.InterfacesListBox.FormattingEnabled = true;
            this.InterfacesListBox.ItemHeight = 19;
            this.InterfacesListBox.Location = new System.Drawing.Point(12, 308);
            this.InterfacesListBox.Name = "InterfacesListBox";
            this.InterfacesListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InterfacesListBox.Size = new System.Drawing.Size(506, 247);
            this.InterfacesListBox.TabIndex = 6;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Silver;
            this.NextBtn.Enabled = false;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.NextBtn.Location = new System.Drawing.Point(337, 578);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(181, 40);
            this.NextBtn.TabIndex = 7;
            this.NextBtn.Text = "Dalej";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Exit1Btn);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 51);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.label3.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(60, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codli Around 1.0";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Around.Properties.Resources.Codli_Around;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(530, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.InterfacesListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunPlayerBtn);
            this.Controls.Add(this.RunStreamerBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Codli Around";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunStreamerBtn;
        private System.Windows.Forms.Button RunPlayerBtn;
        private System.Windows.Forms.Button Exit1Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox InterfacesListBox;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

