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
  int intentos = 0;
    string usr = nombrebox.Text;
    string pwr = contrabox.Text;

    if (usr == null || pwr == null)
    {
        MessageBox.Show("No puede dejar en blanco");
    }
    else
    {
        MessageBox.Show("Bienvenido al sistema");
    }

    if (usr.Equals("admin") && pwr.Equals("admin"))
    {
        fmregistro fmregistro = new fmregistro();
        registro.Show();
    }
    else
    {
        intentos++;

        if (intentos >= 3)
        {
            // Después de tres intentos fallidos, establece las entradas a null
            button1Click1= null;
            contrabox.Clear();
            ombrebox.Clear();
            
            MessageBox.Show("Se han realizado tres intentos fallidos. Las entradas de usuario y contraseña se han restablecido.");
        }
        else
        {
            MessageBox.Show("Usuario y/o contraseña incorrectos");
        }
    }
}

    }
}
