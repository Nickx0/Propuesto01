using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propuesto01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
            if (txtnumero.Text == "")
            {
                errorProvider1.SetError(txtnumero,"Ingrese un numero");
                txtnumero.Focus();
                return;
            }
            errorProvider1.SetError(txtnumero, "");
            int max = int.Parse(txtnumero.Text);
            if (max < 0)
            {
                max = max * -1;
            }

            for(int i = 0; i <= max; i++)
            {
                lstbox.Items.Add(i);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
            if (txtnumero.Text == "")
            {
                errorProvider1.SetError(txtnumero, "Ingrese un numero");
                txtnumero.Focus();
                return;
            }
            errorProvider1.SetError(txtnumero, "");
            int max = int.Parse(txtnumero.Text);
            if (max < 0)
            {
                max = max * -1;
            }

            for (int i = 0; i <= max; i++)
            {
                lstbox.Items.Add("-"+i);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
            if (txtnumero.Text == "")
            {
                errorProvider1.SetError(txtnumero, "Ingrese un numero");
                txtnumero.Focus();
                return;
            }
            errorProvider1.SetError(txtnumero, "");
            if (txtMenor.Text == "")
            {
                errorProvider1.SetError(txtMenor, "Ingrese un numero");
                txtMenor.Focus();
                return;
            }
            errorProvider1.SetError(txtMenor, "");
            int max = int.Parse(txtnumero.Text);
            int min = int.Parse(txtMenor.Text);
            int pro;
            if (min > max)
            {
                pro = max;
                max = min;
                min = pro;
            }

            while (min <= max)
            {
                lstbox.Items.Add(min);
                min++;
            }
        }
    }
}
