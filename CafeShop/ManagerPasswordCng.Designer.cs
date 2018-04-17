namespace CafeShop
{
    partial class ManagerPasswordCng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerPasswordCng));
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.saveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // Textbox2
            // 
            this.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox2.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox2.HintText = "";
            this.Textbox2.isPassword = false;
            this.Textbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox2.LineThickness = 3;
            this.Textbox2.Location = new System.Drawing.Point(43, 158);
            this.Textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(370, 44);
            this.Textbox2.TabIndex = 5;
            this.Textbox2.Text = "New Password";
            this.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox2.Enter += new System.EventHandler(this.Textbox2_Enter);
            this.Textbox2.Leave += new System.EventHandler(this.Textbox2_Leave);
            // 
            // Textbox1
            // 
            this.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox1.HintText = "";
            this.Textbox1.isPassword = false;
            this.Textbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox1.LineThickness = 3;
            this.Textbox1.Location = new System.Drawing.Point(43, 89);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(370, 44);
            this.Textbox1.TabIndex = 5;
            this.Textbox1.Text = "Old Password";
            this.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox1.Enter += new System.EventHandler(this.Textbox1_Enter);
            this.Textbox1.Leave += new System.EventHandler(this.Textbox1_Leave);
            // 
            // saveButton
            // 
            this.saveButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BorderRadius = 0;
            this.saveButton.ButtonText = "Save";
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.DisabledColor = System.Drawing.Color.Gray;
            this.saveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.saveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveButton.Iconimage")));
            this.saveButton.Iconimage_right = null;
            this.saveButton.Iconimage_right_Selected = null;
            this.saveButton.Iconimage_Selected = null;
            this.saveButton.IconMarginLeft = 0;
            this.saveButton.IconMarginRight = 0;
            this.saveButton.IconRightVisible = true;
            this.saveButton.IconRightZoom = 0D;
            this.saveButton.IconVisible = true;
            this.saveButton.IconZoom = 90D;
            this.saveButton.IsTab = false;
            this.saveButton.Location = new System.Drawing.Point(101, 263);
            this.saveButton.Name = "saveButton";
            this.saveButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.saveButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.saveButton.OnHoverTextColor = System.Drawing.Color.White;
            this.saveButton.selected = false;
            this.saveButton.Size = new System.Drawing.Size(241, 48);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Textcolor = System.Drawing.Color.White;
            this.saveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // backbutton1
            // 
            this.backbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton1.Location = new System.Drawing.Point(1, 0);
            this.backbutton1.Name = "backbutton1";
            this.backbutton1.Size = new System.Drawing.Size(63, 23);
            this.backbutton1.TabIndex = 3;
            this.backbutton1.Text = "<<";
            this.backbutton1.UseVisualStyleBackColor = true;
            this.backbutton1.Click += new System.EventHandler(this.backbutton1_Click);
            // 
            // ManagerPasswordCng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbox2);
            this.Controls.Add(this.Textbox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backbutton1);
            this.Name = "ManagerPasswordCng";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox1;
        private Bunifu.Framework.UI.BunifuFlatButton saveButton;
        private System.Windows.Forms.Button backbutton1;
    }
}