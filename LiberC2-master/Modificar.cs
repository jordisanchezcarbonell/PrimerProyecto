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
    public partial class Modificar : Form
    {
       
        List<admin> adminsss;
        admin modificacionadmin = new admin();
    

        public void guardarjson()
        {
            using (StreamWriter file = File.CreateText(@"..\..\Json\Admin1.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, modificacionadmin);
            }
        }

        
       

        public string fo
        {
            get { return textBoxNuevoAdmin.Text; ; }
            set { textBoxNuevoAdmin.Text = value; }

        }
        public string f1
        {
            get { return textBoxCorreoElectronico.Text; ; ; }
            set { textBoxCorreoElectronico.Text = value; }

        }
        public string f2
        {
            get { return textBoxContraseña.Text; ; ; }
            set { textBoxContraseña.Text= value; }

        }
        public string f3
        {
            get { return textBoxNombreyApell.Text; ; ; }
            set { textBoxNombreyApell.Text = value; }

        }
        public Modificar()
        {
            InitializeComponent();
        }
  
    
        private void Modificar_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            adminsss = new List<admin>();

            if (textBoxNuevoAdmin.Text.Length == 0 && textBoxCorreoElectronico.Text.Length == 0 && textBoxContraseña.Text.Length == 0)
            {
                MessageBox.Show("Rellene los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (textBoxContraseña.Text != textBoxcontraseña3.Text)
            {
                MessageBox.Show("La  contraseña no coinciden ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxContraseña.Text.Length==0 || textBoxcontraseña3.Text.Length == 0)
            {
                MessageBox.Show("Contraseña vacia ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                
                
                
                modificacionadmin.usuario = textBoxNuevoAdmin.Text;
                modificacionadmin.correoelectronico = textBoxCorreoElectronico.Text;
                modificacionadmin.nickname = textBoxNombreyApell.Text;
                modificacionadmin.contraseña = textBoxContraseña.Text;



                adminsss.Add(modificacionadmin);
                guardarjson();
                Micuenta prueba = new Micuenta();
                

                this.Close();
               
            }
        }

        private void labelMiCuenta_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcontraseña3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonGestionAdministradores_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxAdministrador_Enter(object sender, EventArgs e)
        {

        }
    }
}
