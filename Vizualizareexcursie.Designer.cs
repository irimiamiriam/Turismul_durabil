namespace Turismul_durabil
{
    partial class Vizualizareexcursie
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generatebutton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Planificari = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PerioadaVizit = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.VizualizareItin = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.VizualizareImg = new System.Windows.Forms.TabPage();
            this.start = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.date = new System.Windows.Forms.Label();
            this.localitate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Planificari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PerioadaVizit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.VizualizareItin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.VizualizareImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(31, 87);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 31);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inceput excursie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sfarsit excursie";
            // 
            // generatebutton
            // 
            this.generatebutton.Location = new System.Drawing.Point(702, 51);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(294, 54);
            this.generatebutton.TabIndex = 4;
            this.generatebutton.Text = "Genereaza excursie";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Planificari);
            this.tabControl1.Controls.Add(this.PerioadaVizit);
            this.tabControl1.Controls.Add(this.VizualizareItin);
            this.tabControl1.Controls.Add(this.VizualizareImg);
            this.tabControl1.Location = new System.Drawing.Point(14, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 512);
            this.tabControl1.TabIndex = 5;
            // 
            // Planificari
            // 
            this.Planificari.Controls.Add(this.dataGridView1);
            this.Planificari.Location = new System.Drawing.Point(8, 39);
            this.Planificari.Name = "Planificari";
            this.Planificari.Padding = new System.Windows.Forms.Padding(3);
            this.Planificari.Size = new System.Drawing.Size(1029, 465);
            this.Planificari.TabIndex = 0;
            this.Planificari.Text = "Planificari";
            this.Planificari.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(993, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // PerioadaVizit
            // 
            this.PerioadaVizit.Controls.Add(this.dataGridView2);
            this.PerioadaVizit.Location = new System.Drawing.Point(8, 39);
            this.PerioadaVizit.Name = "PerioadaVizit";
            this.PerioadaVizit.Padding = new System.Windows.Forms.Padding(3);
            this.PerioadaVizit.Size = new System.Drawing.Size(1029, 465);
            this.PerioadaVizit.TabIndex = 1;
            this.PerioadaVizit.Text = "Perioada de vizitare";
            this.PerioadaVizit.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(993, 439);
            this.dataGridView2.TabIndex = 1;
            // 
            // VizualizareItin
            // 
            this.VizualizareItin.Controls.Add(this.dataGridView3);
            this.VizualizareItin.Location = new System.Drawing.Point(8, 39);
            this.VizualizareItin.Name = "VizualizareItin";
            this.VizualizareItin.Padding = new System.Windows.Forms.Padding(3);
            this.VizualizareItin.Size = new System.Drawing.Size(1029, 465);
            this.VizualizareItin.TabIndex = 2;
            this.VizualizareItin.Text = "Vizualizare Itinerariu";
            this.VizualizareItin.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(18, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(993, 439);
            this.dataGridView3.TabIndex = 2;
            // 
            // VizualizareImg
            // 
            this.VizualizareImg.Controls.Add(this.start);
            this.VizualizareImg.Controls.Add(this.progressBar1);
            this.VizualizareImg.Controls.Add(this.date);
            this.VizualizareImg.Controls.Add(this.localitate);
            this.VizualizareImg.Controls.Add(this.pictureBox1);
            this.VizualizareImg.Location = new System.Drawing.Point(8, 39);
            this.VizualizareImg.Name = "VizualizareImg";
            this.VizualizareImg.Padding = new System.Windows.Forms.Padding(3);
            this.VizualizareImg.Size = new System.Drawing.Size(1029, 465);
            this.VizualizareImg.TabIndex = 3;
            this.VizualizareImg.Text = "Vizualizare Imagini";
            this.VizualizareImg.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(713, 219);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(209, 75);
            this.start.TabIndex = 4;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(647, 102);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(346, 81);
            this.progressBar1.TabIndex = 3;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(472, 89);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(40, 25);
            this.date.TabIndex = 2;
            this.date.Text = "loc";
            // 
            // localitate
            // 
            this.localitate.AutoSize = true;
            this.localitate.Location = new System.Drawing.Point(44, 89);
            this.localitate.Name = "localitate";
            this.localitate.Size = new System.Drawing.Size(40, 25);
            this.localitate.TabIndex = 1;
            this.localitate.Text = "loc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Vizualizareexcursie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 670);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Vizualizareexcursie";
            this.Text = "Vizualizare excursie";
            this.Load += new System.EventHandler(this.Vizualizareexcursie_Load);
            this.tabControl1.ResumeLayout(false);
            this.Planificari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PerioadaVizit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.VizualizareItin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.VizualizareImg.ResumeLayout(false);
            this.VizualizareImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Planificari;
        private System.Windows.Forms.TabPage PerioadaVizit;
        private System.Windows.Forms.TabPage VizualizareItin;
        private System.Windows.Forms.TabPage VizualizareImg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label localitate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}