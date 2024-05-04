using clase_de_windows_for_1_.formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_de_windows_for_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("bienvenido a mi app");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
            
        }

        private void titulo_Click(object sender, EventArgs e)
        {
        

        }

        private void facultad_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usr = nombrebox.Text;
            string pwr = contrabox.Text;
            if (usr == null || pwr == null)
            {
                MessageBox.Show("no puede dejar en blanco");

            }
            else
            {
                MessageBox.Show("bienvenido al sistema");
            }
            if (usr.Equals("admin") && pwr.Equals("admin")) {


                fmregistro fmregistro = new fmregistro();
                registro.Show();

            }
            else
            {
                MessageBox.Show("usuario y contraseña erroneos");
            }
        }
    }
}
