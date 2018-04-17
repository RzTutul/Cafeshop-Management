namespace CafeShop
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomelabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnutextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.banutexbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timelabel3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(499, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.BackColor = System.Drawing.SystemColors.Control;
            this.welcomelabel.Font = new System.Drawing.Font("Baskerville Old Face", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomelabel.Location = new System.Drawing.Point(134, 0);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(417, 38);
            this.welcomelabel.TabIndex = 5;
            this.welcomelabel.Text = "Welcome To Cafe Shop";
            this.welcomelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bnutextbox1
            // 
            this.bnutextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnutextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnutextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnutextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bnutextbox1.HintText = "";
            this.bnutextbox1.isPassword = false;
            this.bnutextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnutextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bnutextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnutextbox1.LineThickness = 3;
            this.bnutextbox1.Location = new System.Drawing.Point(351, 180);
            this.bnutextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bnutextbox1.Name = "bnutextbox1";
            this.bnutextbox1.Size = new System.Drawing.Size(314, 37);
            this.bnutextbox1.TabIndex = 9;
            this.bnutextbox1.Text = "User Name";
            this.bnutextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnutextbox1.Enter += new System.EventHandler(this.bnutextbox1_Enter);
            this.bnutextbox1.Leave += new System.EventHandler(this.bnutextbox1_Leave);
            // 
            // banutexbox2
            // 
            this.banutexbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.banutexbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.banutexbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.banutexbox2.HintForeColor = System.Drawing.Color.Empty;
            this.banutexbox2.HintText = "";
            this.banutexbox2.isPassword = false;
            this.banutexbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.banutexbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.banutexbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.banutexbox2.LineThickness = 3;
            this.banutexbox2.Location = new System.Drawing.Point(351, 261);
            this.banutexbox2.Margin = new System.Windows.Forms.Padding(4);
            this.banutexbox2.Name = "banutexbox2";
            this.banutexbox2.Size = new System.Drawing.Size(314, 45);
            this.banutexbox2.TabIndex = 10;
            this.banutexbox2.Text = "Password";
            this.banutexbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.banutexbox2.Enter += new System.EventHandler(this.banutexbox2_Enter);
            this.banutexbox2.Leave += new System.EventHandler(this.banutexbox2_Leave_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(508, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timelabel3
            // 
            this.Timelabel3.AutoSize = true;
            this.Timelabel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Timelabel3.Font = new System.Drawing.Font("Castellar", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Timelabel3.Location = new System.Drawing.Point(12, 61);
            this.Timelabel3.Name = "Timelabel3";
            this.Timelabel3.Size = new System.Drawing.Size(57, 19);
            this.Timelabel3.TabIndex = 13;
            this.Timelabel3.Text = "Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.welcomelabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 45);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(631, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "LOGIN";
            this.bunifuTileButton1.Location = new System.Drawing.Point(351, 339);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(312, 52);
            this.bunifuTileButton1.TabIndex = 8;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 492);
            this.Controls.Add(this.Timelabel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banutexbox2);
            this.Controls.Add(this.bnutextbox1);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Text = "LOGIN ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel welcomelabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnutextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox banutexbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timelabel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Button button1;
    }
}

