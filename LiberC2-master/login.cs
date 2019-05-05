using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberMiCuenta
{
    public partial class login : Form
    {
        int contadotr=3;
     
        string rutaprueba = @"..\..\Json\Admin1.json";
        admin adminprueba2 = new admin();
        BindingList<admin> adminnistador;
        BindingList<Actividades> Actividades;
        admin adminregistrado;
        public void mostrarcompilador()
        {
            string a = " Se ha enviado un correo a la cuenta asociada   " + textBoxUsuario.Text;
            correo f = new correo(a);
            //f.Show();
           

            f.ShowDialog();
        }
    


        List<admin> pruebaadmin;

        public login()
        {
            InitializeComponent();
           

        }
      

        public void buttonEntrar_Click(object sender, EventArgs e)
        {
            admin adminregistrado = JsonConvert.DeserializeObject<admin>(File.ReadAllText(rutaprueba));

            

            //            admin adminregistrado = JsonConvert.DeserializeObject<admin>(File.ReadAllText(rutaprueba));
            // var adminregistrado = JsonConvert.DeserializeObject<admin>(rutaprueba);
            //var adminregistrado = JsonConvert.DeserializeObject<List<admin>>(rutaprueba);
            if (textBoxUsuario.Text.Length == 0 || textBoxContraseña.Text.Length == 0)
            {
                MessageBox.Show("Introduzca usuario y contraseña ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxUsuario.Text != adminregistrado.usuario||  textBoxContraseña.Text != adminregistrado.contraseña || contadotr < 0 || contadotr > 3)
            {
              
                if(contadotr < 1)
                {
                    MessageBox.Show("ACCESO DENEGADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Te quedan " + contadotr + " intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contadotr--;
                }

            }
            else
            {

                this.Hide();
             
                Micuenta Micu = new Micuenta(adminregistrado);
                Micu.Show();
            }
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelRecuperarContrasenya_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mostrarcompilador();
        }

        private void login_Activated(object sender, EventArgs e)
        {
            admin adminregistrado = JsonConvert.DeserializeObject<admin>(File.ReadAllText(rutaprueba));
            
        }

        private void buttonEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBoxUsuario.Text.Length == 0 || textBoxContraseña.Text.Length == 0)
                {
                    MessageBox.Show("Introduzca usuario y contraseña ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxUsuario.Text != adminregistrado.usuario || textBoxContraseña.Text != adminregistrado.contraseña || contadotr < 0 || contadotr > 3)
                {

                    if (contadotr < 1)
                    {
                        MessageBox.Show("ACCESO DENEGADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Te quedan " + contadotr + " intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        contadotr--;
                    }

                }
                else
                {

                    this.Hide();

                    Micuenta Micu = new Micuenta(adminregistrado);
                    Micu.Show();
                }
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

