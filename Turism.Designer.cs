namespace Turismul_durabil
{
    partial class Turism
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
            this.initialisationButton = new System.Windows.Forms.Button();
            this.generareButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialisationButton
            // 
            this.initialisationButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.initialisationButton.Location = new System.Drawing.Point(88, 141);
            this.initialisationButton.Name = "initialisationButton";
            this.initialisationButton.Size = new System.Drawing.Size(194, 88);
            this.initialisationButton.TabIndex = 0;
            this.initialisationButton.Text = "Initializare";
            this.initialisationButton.UseVisualStyleBackColor = false;
            this.initialisationButton.Click += new System.EventHandler(this.initialisationButton_Click);
            // 
            // generareButton
            // 
            this.generareButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generareButton.Location = new System.Drawing.Point(303, 140);
            this.generareButton.Name = "generareButton";
            this.generareButton.Size = new System.Drawing.Size(194, 88);
            this.generareButton.TabIndex = 1;
            this.generareButton.Text = "Genereaza poster";
            this.generareButton.UseVisualStyleBackColor = false;
            this.generareButton.Click += new System.EventHandler(this.generareButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(519, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 88);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vizualizare excursie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Turism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generareButton);
            this.Controls.Add(this.initialisationButton);
            this.Font = new System.Drawing.Font("MV Boli", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Turism";
            this.Text = "Turism";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button initialisationButton;
        private System.Windows.Forms.Button generareButton;
        private System.Windows.Forms.Button button1;
    }
}

