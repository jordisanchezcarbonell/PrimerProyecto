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
    public partial class Micuenta : Form
    {
        Modificar modif2 = new Modificar(); 
        List<admin> adminsss;
        int count = 0;
        BindingList<Llbreria> listActividades;
        admin adminregistrado = new admin();
        string rutaprueba = @"..\..\Json\Admin1.json";
        BindingList<Actividades> nuevaactividad;
        string ruta = @"C:\Users\jordi\Desktop\listadeactividad.json";
        public Micuenta()
        {
            InitializeComponent();
        }
        public Micuenta( admin adminregistrado)
        {
            InitializeComponent();
            textBoxCuentaAdmin.Text = adminregistrado.usuario;
            textBoxCorreoelectronico.Text = adminregistrado.correoelectronico;
            textBoxnombreyappelido.Text = adminregistrado.nickname;

        }
        public void cargarAdmin()
        {
            JArray jarrayactividad = JArray.Parse(File.ReadAllText(ruta));
            nuevaactividad = jarrayactividad.ToObject<BindingList<Actividades>>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            labelMiCuenta.Text = "Meva conta";
        }

        private void Micuenta_Load(object sender, EventArgs e)
        {
            modif2.fo = textBoxCuentaAdmin.Text;
            modif2.f1 = textBoxCorreoelectronico.Text;
            modif2.f2 = textBoxnombreyappelido.Text;
            modif2.f3 = textBoxnombreyappelido.Text;
        }


        private void textBoxCuentaAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
           
            if(count < 1) { 
            textBoxCuentaAdmin.Text = this.textBoxCuentaAdmin.Text;
            modif2.fo = textBoxCuentaAdmin.Text;
            modif2.f1 = textBoxCorreoelectronico.Text;
            modif2.f2 = textBoxnombreyappelido.Text;
            modif2.f3 = textBoxnombreyappelido.Text;
            modif2.Show();
                count++;
            }
            else
            {

                MessageBox.Show("Ya has editado el perfil " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelMiCuenta_Click(object sender, EventArgs e)
        {

        }

        private void Micuenta_Activated(object sender, EventArgs e)
        {
            admin adminregistrado = JsonConvert.DeserializeObject<admin>(File.ReadAllText(rutaprueba));
            textBoxCuentaAdmin.Text = adminregistrado.usuario;
            textBoxnombreyappelido.Text = adminregistrado.nickname;
            textBoxCorreoelectronico.Text = adminregistrado.correoelectronico;

        }

        private void toolStripButtonAnyadirLibrerias_Click(object sender, EventArgs e)
        {
            AgregarLibreria a = new AgregarLibreria();
            a.ShowDialog();
        }

        private void toolStripButtonAnyadirActividades_Click(object sender, EventArgs e)
        {
            AñadirActividad b = new AñadirActividad();
            b.ShowDialog();
        }

        private void toolStripButtonActividades_Click(object sender, EventArgs e)
        {
            Lista_de_actividad c = new Lista_de_actividad();
            c.ShowDialog();
        }

        private void toolStripButtonLibrerias_Click(object sender, EventArgs e)
        {
            listadelibrerias d = new listadelibrerias();
            d.ShowDialog();

        }

        private void toolStripButtonGestionAdministradores_Click(object sender, EventArgs e)
        {
            listadeadmin f = new listadeadmin();

            f.ShowDialog();
        }

        private void groupBoxCuentaadmin_Enter(object sender, EventArgs e)
        {

        }
    }
}
