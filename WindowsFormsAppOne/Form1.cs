using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Name = "Primera aplicacion, programacion III";
            this.Text = "Mi primera app";
            this.BackColor = Color.DarkGray;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show ("Bienvenidos a mi primera App");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BackColor = Color.LightCoral;
            MessageBox.Show("Magia!!!");
        }

        private void BotonUno_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se habilito el Doble click en boton");
            //this.BackColor = Color.LightPink;
            if (Nombre.Text == "")
                Nombre.BackColor = Color.LightYellow;
              
            else
                Nombre.BackColor = System.Drawing.SystemColors.Control;

        }

        private void BotonUno_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Font mifuente = new Font("Calibri", 12,FontStyle.Bold);
            label1.Font = mifuente;

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.FloralWhite;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Cursor = Cursors.Arrow;
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("El texto ingresado tiene " + textbox2.Text.Length + " Caracteres");
        }
    }
    
}
