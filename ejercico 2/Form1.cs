using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercico_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevoregistro_Click(object sender, EventArgs e)
        {
            txtgrados.Clear();
            lblrepuesta.Text = " ";
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            double fare, celsius;
            if (double.TryParse(txtgrados.Text, out fare))
            {
                celsius = (fare - 32) * 5 / 9;
                lblrepuesta.Text = "Grados Celsius" + celsius.ToString("N2");
            }
            else 
            {
                lblrepuesta.Text = " Esto no es ´posible, por favor ingresar un numero";
            }
        }
    }
}
