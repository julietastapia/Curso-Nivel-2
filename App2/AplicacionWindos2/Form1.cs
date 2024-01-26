using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string elem1 = Txt1.Text;
            string elem2 = Txt2.Text;
            Ls1.Items.Add( "Apellido y Nombre: " + elem1 +" "+ elem2);

            string elem3 = Txt3.Text;
            Ls1.Items.Add("Edad: " + elem3);

             string elem4 = Txt4.Text;
            Ls1.Items.Add("Dirección: " + elem4);

            if (Txt1.Text == "")
                Txt1.BackColor = Color.Red;
            else
                Txt1.BackColor = System.Drawing.SystemColors.Control;

            if (Txt2.Text == "")
                Txt2.BackColor = Color.Red;
            else
                Txt2.BackColor = System.Drawing.SystemColors.Control;

            if (Txt3.Text == "")
                Txt3.BackColor = Color.Red;
            else
                Txt3.BackColor = System.Drawing.SystemColors.Control;

            if (Txt4.Text == "")
                Txt4.BackColor = Color.Red;
            else
                Txt4.BackColor = System.Drawing.SystemColors.Control;
            
        }

        private void Txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 1 || e.KeyChar > 99) && e.KeyChar != 0)
                e.Handled = true; 
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo de la app...");
            Application.Exit();
        }
    }
}
