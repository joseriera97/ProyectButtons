using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK.\n    Perfect");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel.\n    Okey");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string mensaje ="Desea continuar?";
            const string confirm = "confirmado";
            DialogResult result = MessageBox.Show(mensaje, confirm,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // Si el boton presionado es NO
            if (result == DialogResult.No)
            {
                // cancelar
                MessageBox.Show("Cancelando");

            }
            //Si es Yes
            if (result == DialogResult.Yes)
            {
                // Continuar
                MessageBox.Show("Continuando");

            }
            /*
            Form1.Hide();

            Form2.Show();*/

        }
    }
}
