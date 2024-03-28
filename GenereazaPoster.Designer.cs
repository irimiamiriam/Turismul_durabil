namespace Turismul_durabil
{
    partial class GenereazaPoster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adaugabutton = new System.Windows.Forms.Button();
            this.localitatecomboBox = new System.Windows.Forms.ComboBox();
            this.imaginecomboBox = new System.Windows.Forms.ComboBox();
            this.imaginilistBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localitate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imagine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista imagini:";
            // 
            // adaugabutton
            // 
            this.adaugabutton.Location = new System.Drawing.Point(85, 325);
            this.adaugabutton.Name = "adaugabutton";
            this.adaugabutton.Size = new System.Drawing.Size(212, 43);
            this.adaugabutton.TabIndex = 3;
            this.adaugabutton.Text = "Adauga";
            this.adaugabutton.UseVisualStyleBackColor = true;
            this.adaugabutton.Click += new System.EventHandler(this.adaugabutton_Click);
            // 
            // localitatecomboBox
            // 
            this.localitatecomboBox.FormattingEnabled = true;
            this.localitatecomboBox.Location = new System.Drawing.Point(85, 131);
            this.localitatecomboBox.Name = "localitatecomboBox";
            this.localitatecomboBox.Size = new System.Drawing.Size(273, 33);
            this.localitatecomboBox.TabIndex = 4;
            this.localitatecomboBox.SelectedIndexChanged += new System.EventHandler(this.localitatecomboBox_SelectedIndexChanged);
            // 
            // imaginecomboBox
            // 
            this.imaginecomboBox.FormattingEnabled = true;
            this.imaginecomboBox.Location = new System.Drawing.Point(85, 242);
            this.imaginecomboBox.Name = "imaginecomboBox";
            this.imaginecomboBox.Size = new System.Drawing.Size(273, 33);
            this.imaginecomboBox.TabIndex = 5;
            this.imaginecomboBox.SelectedIndexChanged += new System.EventHandler(this.imaginecomboBox_SelectedIndexChanged);
            // 
            // imaginilistBox
            // 
            this.imaginilistBox.FormattingEnabled = true;
            this.imaginilistBox.ItemHeight = 25;
            this.imaginilistBox.Location = new System.Drawing.Point(85, 437);
            this.imaginilistBox.Name = "imaginilistBox";
            this.imaginilistBox.Size = new System.Drawing.Size(297, 154);
            this.imaginilistBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 633);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 31);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Titlu";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(513, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(537, 487);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(576, 554);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(427, 54);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Genereaza poster";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // GenereazaPoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1076, 704);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imaginilistBox);
            this.Controls.Add(this.imaginecomboBox);
            this.Controls.Add(this.localitatecomboBox);
            this.Controls.Add(this.adaugabutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenereazaPoster";
            this.Text = "Genereaza Poster";
            this.Load += new System.EventHandler(this.GenereazaPoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adaugabutton;
        private System.Windows.Forms.ComboBox localitatecomboBox;
        private System.Windows.Forms.ComboBox imaginecomboBox;
        private System.Windows.Forms.ListBox imaginilistBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button generateButton;
    }
}