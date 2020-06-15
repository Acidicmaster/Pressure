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
    public partial class Pressure_Calc : Form
    {
        public Pressure_Calc()
        {
            InitializeComponent();
        }

        private void Input_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void predict_Btn_Click(object sender, EventArgs e)
        {
            double porosity = double.Parse(porosity_textBox.Text);
            double den = double.Parse(density_textBox.Text);
            double d = double.Parse(maxDepth_Box.Text);
            double time = double.Parse(Time_TextBox.Text);

            if (porosity.ToString().Trim().Equals("") || porosity >= 1.0)
            {

                MessageBox.Show("Error porosity is empty or greater than 1", "Enter Porosity", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (den.ToString().Trim().Equals("") || d.ToString().Trim().Equals("") || time.ToString().Trim().Equals(""))
            {

                MessageBox.Show("Empty inputs", "Enter data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Pressure_call calx = new Pressure_call();

                double Vs = calx.getVs(porosity);
                double Vp = calx.getVp(Vs);
                double gam = calx.getGamma(den, Vs, Vp);


                DataTable dt = new DataTable();
                DataColumn dc = new DataColumn("Points");
                DataColumn dc2 = new DataColumn("Pressure");
                DataColumn dc3 = new DataColumn("Depth");
                DataColumn dc4 = new DataColumn("Shear Velocity");
                dt.Columns.Add(dc);
                dt.Columns.Add(dc2);
                dt.Columns.Add(dc3);
                dt.Columns.Add(dc4);
                int depth = 0; int i = 0;
                // for(int i= 0; i < 15; i++)
                while (depth < d)
                {

                    double v = calx.getV(depth);
                    double g = calx.getG(v, gam);
                    double Pf = calx.getPf(g, Vs);
                    double Pore = calx.getPorePress(Pf, depth);



                    /* DataTable dt = new DataTable();
                     DataColumn dc = new DataColumn("Points");
                     DataColumn dc2 = new DataColumn("Pressure");
                     DataColumn dc3 = new DataColumn("Depth");
                     DataColumn dc4 = new DataColumn("Shear Velocity");
                
                     //add the columns to the datatable
                     dt.Columns.Add(dc);
                     dt.Columns.Add(dc2);
                     dt.Columns.Add(dc3);
                     dt.Columns.Add(dc4);**/



                    DataRow dr = dt.NewRow();

                    dr["Points"] = i;
                    dr["pressure"] = Pore;
                    dr["Depth"] = depth;
                    dr["Shear Velocity"] = v;
                    dt.Rows.Add(dr);


                    // datagrid_view.DataSource = dt;


                    depth = depth + 200;
                    i++;

                }

                datagrid_view.DataSource = dt;
            }
            
            
            


        }

        private void datagrid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Application.Exit();
        }

        private void Pressure_Calc_Load(object sender, EventArgs e)
        {
            
        }  
    }
}
