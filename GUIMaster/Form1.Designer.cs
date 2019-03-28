namespace GUIMaster
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.gbxFont = new System.Windows.Forms.GroupBox();
            this.rbComic = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.rbSerif = new System.Windows.Forms.RadioButton();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chbRead = new System.Windows.Forms.CheckBox();
            this.chbEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.rbBottom = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbxFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(55, 40);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 0;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtText);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(228, 59);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(125, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Počet znakov v texboxe:";
            // 
            // gbxFont
            // 
            this.gbxFont.Controls.Add(this.rbComic);
            this.gbxFont.Controls.Add(this.rbArial);
            this.gbxFont.Controls.Add(this.rbSerif);
            this.gbxFont.Location = new System.Drawing.Point(453, 30);
            this.gbxFont.Name = "gbxFont";
            this.gbxFont.Size = new System.Drawing.Size(200, 100);
            this.gbxFont.TabIndex = 3;
            this.gbxFont.TabStop = false;
            this.gbxFont.Text = "Font";
            // 
            // rbComic
            // 
            this.rbComic.AutoSize = true;
            this.rbComic.Location = new System.Drawing.Point(43, 70);
            this.rbComic.Name = "rbComic";
            this.rbComic.Size = new System.Drawing.Size(81, 17);
            this.rbComic.TabIndex = 2;
            this.rbComic.TabStop = true;
            this.rbComic.Text = "Comic Sans";
            this.rbComic.UseVisualStyleBackColor = true;
            this.rbComic.CheckedChanged += new System.EventHandler(this.rbComic_CheckedChanged);
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(43, 46);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(45, 17);
            this.rbArial.TabIndex = 1;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            this.rbArial.CheckedChanged += new System.EventHandler(this.rbArial_CheckedChanged);
            // 
            // rbSerif
            // 
            this.rbSerif.AutoSize = true;
            this.rbSerif.Location = new System.Drawing.Point(43, 22);
            this.rbSerif.Name = "rbSerif";
            this.rbSerif.Size = new System.Drawing.Size(119, 17);
            this.rbSerif.TabIndex = 0;
            this.rbSerif.TabStop = true;
            this.rbSerif.Text = "Microsoft Sans Serif";
            this.rbSerif.UseVisualStyleBackColor = true;
            this.rbSerif.CheckedChanged += new System.EventHandler(this.rbSerif_CheckedChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(67, 150);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "blue",
            "red",
            "green",
            "yellow",
            "grey"});
            this.comboBox1.Location = new System.Drawing.Point(58, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chbRead
            // 
            this.chbRead.AutoSize = true;
            this.chbRead.Location = new System.Drawing.Point(67, 241);
            this.chbRead.Name = "chbRead";
            this.chbRead.Size = new System.Drawing.Size(69, 17);
            this.chbRead.TabIndex = 6;
            this.chbRead.Text = "read only";
            this.chbRead.UseVisualStyleBackColor = true;
            this.chbRead.CheckedChanged += new System.EventHandler(this.chbRead_CheckedChanged);
            // 
            // chbEnabled
            // 
            this.chbEnabled.AutoSize = true;
            this.chbEnabled.Location = new System.Drawing.Point(67, 265);
            this.chbEnabled.Name = "chbEnabled";
            this.chbEnabled.Size = new System.Drawing.Size(65, 17);
            this.chbEnabled.TabIndex = 7;
            this.chbEnabled.Text = "Enabled";
            this.chbEnabled.UseVisualStyleBackColor = true;
            this.chbEnabled.CheckedChanged += new System.EventHandler(this.chbEnabled_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNone);
            this.groupBox1.Controls.Add(this.rbBottom);
            this.groupBox1.Controls.Add(this.rbTop);
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Controls.Add(this.rbLeft);
            this.groupBox1.Location = new System.Drawing.Point(404, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dock";
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(27, 23);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(43, 17);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Left";
            this.rbLeft.UseVisualStyleBackColor = true;
            this.rbLeft.CheckedChanged += new System.EventHandler(this.rbLeft_CheckedChanged);
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(27, 46);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(50, 17);
            this.rbRight.TabIndex = 1;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "Right";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.rbRight_CheckedChanged);
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(27, 69);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(44, 17);
            this.rbTop.TabIndex = 2;
            this.rbTop.TabStop = true;
            this.rbTop.Text = "Top";
            this.rbTop.UseVisualStyleBackColor = true;
            this.rbTop.CheckedChanged += new System.EventHandler(this.rbTop_CheckedChanged);
            // 
            // rbBottom
            // 
            this.rbBottom.AutoSize = true;
            this.rbBottom.Location = new System.Drawing.Point(27, 92);
            this.rbBottom.Name = "rbBottom";
            this.rbBottom.Size = new System.Drawing.Size(58, 17);
            this.rbBottom.TabIndex = 3;
            this.rbBottom.TabStop = true;
            this.rbBottom.Text = "Bottom";
            this.rbBottom.UseVisualStyleBackColor = true;
            this.rbBottom.CheckedChanged += new System.EventHandler(this.rbBottom_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(27, 115);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 4;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.rbNone_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUIMaster.Properties.Resources.images;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 216);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbEnabled);
            this.Controls.Add(this.chbRead);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.gbxFont);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxFont.ResumeLayout(false);
            this.gbxFont.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox gbxFont;
        private System.Windows.Forms.RadioButton rbComic;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.RadioButton rbSerif;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chbRead;
        private System.Windows.Forms.CheckBox chbEnabled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbBottom;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

