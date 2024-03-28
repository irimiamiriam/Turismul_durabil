using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turismul_durabil.SqlDatabase;
using static System.Net.Mime.MediaTypeNames;

namespace Turismul_durabil
{
    public partial class Vizualizareexcursie : Form
    {
        public Vizualizareexcursie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vizualizareexcursie_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatabaseHelper.Planificari();

        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DatabaseHelper.PlanificariValabile(dateTimePicker2.Value, dateTimePicker1.Value);
            dataGridView3.DataSource = DatabaseHelper.Itinerariu(dateTimePicker2.Value, dateTimePicker1.Value);
            dataGridView3.Sort(dataGridView3.Columns["Data"],ListSortDirection.Ascending);
        }

        private void start_Click(object sender, EventArgs e)
        {
            string[] locitinerariu=new string[100];
            string[] dataitinerariu = new string[100];
            int i = 0;
           foreach (DataGridViewRow row in dataGridView3.Rows) {
                if(row.IsNewRow) { break; }
                locitinerariu[i] = row.Cells[0].Value.ToString();
                dataitinerariu[i]= row.Cells[1].Value.ToString();
                i++;
            }
           progressBar1.Maximum= i;
            i = 0;
            string[] imagini = DatabaseHelper.ImaginiItinerariu(locitinerariu);
            foreach(string loc in locitinerariu)
            {
                if(string.IsNullOrEmpty(loc)) { break; }
                localitate.Text= loc;
                date.Text = dataitinerariu[i];
                string path = "C:\\Users\\Miriam\\Documents\\Aplicatii C#\\Turismul_durabil\\Imagini\\" + imagini[i];
                pictureBox1.Image= System.Drawing.Image.FromFile(path);
                  i++;
                progressBar1.Value= i; 
                Task.Delay(2000).Wait();
             
                
            }


        }
    }
}
