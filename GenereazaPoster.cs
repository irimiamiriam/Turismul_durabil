using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_durabil.SqlDatabase;

namespace Turismul_durabil
{
    public partial class GenereazaPoster : Form
    {
        public GenereazaPoster()
        {
            InitializeComponent();
        }

        private void GenereazaPoster_Load(object sender, EventArgs e)
        {
            string[] localitati = DatabaseHelper.GetLocComboBox();
            for(int i=0; i < localitati.Length && localitati[i]!=null; i++)
            {
                localitatecomboBox.Items.Add(localitati[i]);
            }
        }

        private void localitatecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imaginecomboBox.Items.Clear();
            string[] imagini = DatabaseHelper.GetImaginiComboBox(localitatecomboBox.SelectedItem.ToString());
            for (int i = 0; i < imagini.Length && imagini[i] != null; i++)
            {
                imaginecomboBox.Items.Add(imagini[i]);
            }
        }

        private void imaginecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imagine = imaginecomboBox.SelectedItem.ToString();
            string path = "C:\\Users\\Miriam\\Documents\\Aplicatii C#\\Turismul_durabil\\Imagini\\" + imagine;
            pictureBox.Image = Image.FromFile(path);
          
        }

        private void adaugabutton_Click(object sender, EventArgs e)
        {
            if (imaginilistBox.Items.Count < 10)
            {
                imaginilistBox.Items.Add(imaginecomboBox.SelectedItem.ToString());
            }
            else MessageBox.Show("Ati introdus deja 10 imagini");
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Bitmap poster = new Bitmap(1000, 1000);
            Graphics g = Graphics.FromImage(poster);
            Brush brush = new SolidBrush(Color.Beige);
            g.FillRectangle(brush, 0, 0, poster.Width, poster.Height);
            Font titleFont = new Font("Arial", 16, FontStyle.Bold); 
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            g.DrawString(textBox1.Text, titleFont, Brushes.Black, new PointF(poster.Width / 2, 10), stringFormat);
            int x = 10; 
            int y = 40; 
            int spacing = 10;
            foreach(string imagine in imaginilistBox.Items)
            {
                string path = "C:\\Users\\Miriam\\Documents\\Aplicatii C#\\Turismul_durabil\\Imagini\\" + imagine;
                Image image = Image.FromFile(path);
                g.DrawImage(image, new Rectangle(x, y, 90, 90));
                x += 90+spacing;
                if (x + 90 + spacing > poster.Width)
                {
                    x = 10;
                    y += 90 + spacing; 
                }
                image.Dispose();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
           
                poster.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
