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
    public partial class Turism : Form
    {
        public Turism()
        {
            InitializeComponent();
        }

        private void initialisationButton_Click(object sender, EventArgs e)
        {
            DatabaseHelper.Initialisation();
        }

        private void generareButton_Click(object sender, EventArgs e)
        {
            GenereazaPoster gp = new GenereazaPoster();
            this.Hide();
            gp.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vizualizareexcursie vizualizareexcursie = new Vizualizareexcursie();
            this.Hide();
            vizualizareexcursie.ShowDialog();
            this.Show();
        }
    }
}
