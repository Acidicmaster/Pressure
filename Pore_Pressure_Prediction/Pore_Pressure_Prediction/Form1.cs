using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pore_Pressure_Prediction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void go_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pressure_Calc Pore = new Pressure_Calc();
            Pore.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
            
    }
}
